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

        public async Task<List<PlantacoesCadastradas>> deveRetornarPlantacoesCadastradas()
        {
            string url = $"{conexaoBackEnd}/plantacoes/fornecimentos-cadastrados";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        //Lê a resposta do servidor
                        string responseBody = await response.Content.ReadAsStringAsync();

                        //Deserializa o JSON para a classe 
                        var plantacoes = JsonConvert.DeserializeObject<List<PlantacoesCadastradas>>(responseBody);

                        return plantacoes;
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
                //Trata exceções como problema de conexão
                Console.WriteLine($"Erro ao conectar ao servidor: {ex.Message}");
                return [];
            }

        }

        public async Task<bool> deveDefinirAlimentoComoPronto(long id, double valorFinal)
        {
            string url = $"{conexaoBackEnd}/plantacoes/definir-pronto";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Criar um array JSON com os dados necessários
                    var dados = new[]
                    {
                new
                {
                    id_plantacao = id,
                    valor_final = valorFinal
                }
            };

                    var content = new StringContent(JsonConvert.SerializeObject(dados), Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PatchAsync(url, content);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar ao servidor: {ex.Message}");
                return false;
            }
        }


        public async Task<Relatorio> deveRetornarRelatorio()
        {
            string url = $"{conexaoBackEnd}/vendas/relatorios";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        //Lê a resposta do servidor
                        string responseBody = await response.Content.ReadAsStringAsync();

                        //Deserializa o JSON para a classe 
                        var relatorio = JsonConvert.DeserializeObject<Relatorio>(responseBody);

                        return relatorio;
                    }
                    else
                    {
                        Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                //Trata exceções como problema de conexão
                Console.WriteLine($"Erro ao conectar ao servidor: {ex.Message}");
                return null;
            }

        }


    }


}
