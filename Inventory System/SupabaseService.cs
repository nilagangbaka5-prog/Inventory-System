
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Inventory_System
{
    public class SupabaseService
    {
        private readonly string supabaseUrl =
            "https://knrpuigkiurccvoynojl.supabase.co";

        private readonly string supabaseKey =
            "sb_publishable_5vHUXNOCgTbnDYaokecm-g_YRGAeJLp";

        private static readonly HttpClient client = new HttpClient();

        public string AccessToken { get; private set; }
        public string UserId { get; private set; }

        // REGISTER
        public async Task<string> RegisterAsync(
            string email, string password, string fullName)
        {
            var data = new
            {
                email,
                password,
                data = new { full_name = fullName }
            };

            string json = JsonConvert.SerializeObject(data);

            var response = await SendAsync(
                HttpMethod.Post,
                "/auth/v1/signup",
                json
            );

            return response;
        }

        // LOGIN
        public async Task LoginAsync(string email, string password)
        {
            var data = new
            {
                email,
                password
            };

            string json = JsonConvert.SerializeObject(data);

            string result = await SendAsync(
                HttpMethod.Post,
                "/auth/v1/token?grant_type=password",
                json
            );

            JObject response = JObject.Parse(result);

            AccessToken = response["access_token"]?.ToString();
            UserId = response["user"]?["id"]?.ToString();

            if (string.IsNullOrWhiteSpace(AccessToken) ||
                string.IsNullOrWhiteSpace(UserId))
            {
                throw new Exception("Unable to retrieve login session.");
            }
        }

        // GET PRODUCTS
        public async Task<List<Product>> GetProductsAsync()
        {
            string path =
                "/rest/v1/products?select=id,name,category,quantity,price" +
                "&user_id=eq." + Uri.EscapeDataString(UserId);

            string result = await SendAsync(
                HttpMethod.Get,
                path,
                null,
                true
            );

            return JsonConvert.DeserializeObject<List<Product>>(result)
                   ?? new List<Product>();
        }

        // ADD PRODUCT
        public async Task AddProductAsync(Product product)
        {
            var data = new
            {
                user_id = UserId,
                name = product.Name,
                category = product.Category,
                quantity = product.Quantity,
                price = product.Price
            };

            string json = JsonConvert.SerializeObject(data);

            await SendAsync(
                HttpMethod.Post,
                "/rest/v1/products",
                json,
                true
            );
        }

        // UPDATE PRODUCT
        public async Task UpdateProductAsync(Product product)
        {
            var data = new
            {
                name = product.Name,
                category = product.Category,
                quantity = product.Quantity,
                price = product.Price
            };

            string json = JsonConvert.SerializeObject(data);

            string path =
                "/rest/v1/products?id=eq." +
                Uri.EscapeDataString(product.Id) +
                "&user_id=eq." +
                Uri.EscapeDataString(UserId);

            await SendAsync(
                new HttpMethod("PATCH"),
                path,
                json,
                true
            );
        }

        // DELETE PRODUCT
        public async Task DeleteProductAsync(string productId)
        {
            string path =
                "/rest/v1/products?id=eq." +
                Uri.EscapeDataString(productId) +
                "&user_id=eq." +
                Uri.EscapeDataString(UserId);

            await SendAsync(
                HttpMethod.Delete,
                path,
                null,
                true
            );
        }


        // RECORD STOCK MOVEMENT
        public async Task RecordStockMovementAsync(
            string productId,
            string type,
            int quantity)
        {
            var data = new
            {
                p_product_id = long.Parse(productId),
                p_type = type,
                p_quantity = quantity
            };

            string json = JsonConvert.SerializeObject(data);

            await SendAsync(
                HttpMethod.Post,
                "/rest/v1/rpc/record_stock_movement",
                json,
                true
            );
        }


        // COMMON HTTP REQUEST
        private async Task<string> SendAsync(
            HttpMethod method,
            string path,
            string json = null,
            bool authenticated = false)
        {
            using (var request = new HttpRequestMessage(
                method, supabaseUrl + path))
            {
                request.Headers.Add("apikey", supabaseKey);

                if (authenticated)
                {
                    if (string.IsNullOrWhiteSpace(AccessToken))
                        throw new Exception("Please log in first.");

                    request.Headers.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue(
                            "Bearer", AccessToken);
                }

                if (json != null)
                {
                    request.Content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json"
                    );
                }

                using (var response = await client.SendAsync(request))
                {
                    string result =
                        await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                        throw new Exception(result);

                    return result;
                }
            }
        }
    }
}
