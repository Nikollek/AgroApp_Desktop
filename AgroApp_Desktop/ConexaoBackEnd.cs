using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AgroApp_Desktop
{
    internal class ConexaoBackEnd
    {

        private string conexaoBackEnd = "http://localhost:9095";

        public async Task<bool> deveFazerLogin(string email, string senha)
        {
            string url = $"{conexaoBackEnd}/usuarios/login?email={email}&senha={senha}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        return true; //login bem sucedido
                    }
                }
                return false; //falha no login
            }
            catch (Exception ex)
            {
                // Log ou manipulação do erro sem dependência de UI
                Console.WriteLine($"Erro ao conectar ao servidor: {ex.Message}");
                return false;
            }
        }

        public async Task<List<VendasEfetivadas>> deveRetornarVendasEfetivadas()
        {
            string url = $"{conexaoBackEnd}/vendas/efetivadas";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode) 
                    {
                        // Lê a resposta do servidor
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Deserializa o JSON para uma lista de VendasEfetivadas
                        var vendas = JsonConvert.DeserializeObject<List<VendasEfetivadas>>(responseBody);

                        return vendas;
                    }
                    else
                    {
                        Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                        return [];
                    }
                }
             }
            catch (Exception ex)
            {
                // Trata exceções, como problemas de conexão
                Console.WriteLine($"Erro ao conectar ao servidor: {ex.Message}");
                return [];
            }
        }

        public async Task<List<Fornecedores>> deveRetornarFornecedores()
        {
            string url = $"{conexaoBackEnd}/fornecedores/cadastrados";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        //Lê a resposta do servidor
                        string responseBody = await response.Content.ReadAsStringAsync();

                        //Deserializa o JSON para uma lista de fornecedores
                        var fornecedores = JsonConvert.DeserializeObject<List<Fornecedores>>(responseBody);

                        return fornecedores;

                    }
                    else
                    {
                        Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                        return [];
                    }
                }
            }
            catch (Exception ex) 
            {
                //Trata exceções como problemas de conexão
                Console.WriteLine($"Erro ao conectar ao servidor: {ex.Message}");
                return [];
            }

        }

    }
}
