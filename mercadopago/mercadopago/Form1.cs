using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Net;
using System.Xml;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;
using RestSharp;
using System.Drawing.Drawing2D;

// -------------------------------------------------------- //
// Protótipo para homologação desenvolvido em C#.Net        //
// Angelo Macedo                    10/09/2020              //
// Necessário importar as referências                       //
//             * Newtonsoft                                 //
//             * RestSharp                                  //
// Necessário configurar:                                   //
//             * access_token                               //
//             * fixed_amount = true (para fixar o valor)   //
// -------------------------------------------------------- //

namespace mercadopago
{
    public partial class Form1 : Form
    {
        public string token = "APP_USR-???????";
        public string collector_id = "?????????";
        public string external_id = "PDV???????";

public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            var terminal = external_id;
            var pedido = terminal + txtPedido.Text;
                
            var client = new RestClient("https://api.mercadopago.com/mpmobile/instore/qr/" + collector_id + "/" + terminal + "?access_token=" + token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "09bf7eaa-5a1d-119c-fc71-5ea34f17856f");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("x-ttl-store-preference", "180");
            request.AddParameter("application/json", "{\n    \"external_reference\": \"" + pedido + "\",\n    \"notification_url\": \"https://hookb.in/Z2Qx2PQkdXuR33eLJDM2\",\n      \"items\" :[{\n      \t\"id\": \"NALIN\",\n        \"title\" : \"Compra Lojas Nalin\",\n        \"currency_id\" : \"BRL\",\n        \"unit_price\" : " + txtValor.Text + ",\n        \"description\": \"Lojas Nalin\",\n        \"quantity\" : 1,\n        \"picture_url\": \"\"\n      }],\n      \"payment_methods\": {\n        \"installments\": 12\n      }\n}", ParameterType.RequestBody);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            IRestResponse response = client.Execute(request);

            var deserialiser = JsonConvert.DeserializeObject<RetornoSucesso>(response.Content);

            //MessageBox.Show("Status: " + deserialiser.status);
            
        }
              

        private void btnCriarTerminal_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://api.mercadopago.com/pos?access_token=" + token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "9477108c-a248-6aad-8498-e3ce1977dd92");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\n    \"name\":\"LOJAS NALIN (00201)\", \n    \"fixed_amount\": true,\n    \"category\": null,\n    \"external_id\": \"PDV00201\",\n    \"store_id\": null,\n    \"url\": null\n}", ParameterType.RequestBody);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            IRestResponse response = client.Execute(request);
            
            var deserialiser = JsonConvert.DeserializeObject<RetornoSucesso>(response.Content);
            try
            {
                qrCode.Image = GetImage(deserialiser.image);
            }
            catch
            { }
            

            
        }

        
        public Image GetImage(string value)
        {
            byte[] bytes = Convert.FromBase64String(value);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        public class RetornoSucesso
        {
            public string error { get; set; }
            public string message { get; set; }
            public string image { get; set; }
            public int status { get; set; }
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://api.mercadopago.com/pos?access_token=" + token + "&external_id=" + external_id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "3d8eb0f0-5dd6-c34e-8f43-73158a31b401");
            request.AddHeader("cache-control", "no-cache");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            IRestResponse response = client.Execute(request);

            var deserialiser = JsonConvert.DeserializeObject<Root>(response.Content);
                       
            try
            {
                qrCode.Size = new System.Drawing.Size(150, 150);
                qrCode.SizeMode = PictureBoxSizeMode.StretchImage;
                qrCode.BorderStyle = BorderStyle.Fixed3D;

                qrCode.ImageLocation = deserialiser.results[0].qr.image;
               
            }
            catch
            { }

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var pedido = external_id + txtPedido.Text;

            var client = new RestClient("https://api.mercadopago.com/merchant_orders?external_reference=" + pedido + "&access_token=" + token);
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "ddbfb365-1b4e-0141-dcc9-54db55e722bf");
            request.AddHeader("cache-control", "no-cache");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            IRestResponse response = client.Execute(request);

            var deserialiser = JsonConvert.DeserializeObject<Root>(response.Content);

            try
            {
                var statusPay = deserialiser.elements[0].payments[0].status;

                if (statusPay == "approved")
                {
                    MessageBox.Show("PAGO");
                }
                else
                {
                    MessageBox.Show(statusPay);
                }
            }
            catch
            {
                MessageBox.Show("Aguardando Pagamento...");
            }

         }

        public class Paging
        {
            public int total { get; set; }
            public int offset { get; set; }
            public int limit { get; set; }
        }

        public class Qr
        {
            public string image { get; set; }
            public string template_document { get; set; }
            public string template_image { get; set; }
        }

        public class Result
        {
            public int user_id { get; set; }
            public string name { get; set; }
            public bool fixed_amount { get; set; }
            public string external_id { get; set; }
            public int id { get; set; }
            public Qr qr { get; set; }
            public DateTime date_created { get; set; }
            public DateTime date_last_updated { get; set; }
        }

        public class Root
        {
            public Paging paging { get; set; }
            public List<Element> elements { get; set; }
            public List<Result> results { get; set; }
        }

        public class Payment
        {
            public long id { get; set; }
            public double transaction_amount { get; set; }
            public double total_paid_amount { get; set; }
            public int shipping_cost { get; set; }
            public string currency_id { get; set; }
            public string status { get; set; }
            public string status_detail { get; set; }
            public string operation_type { get; set; }
            public DateTime date_approved { get; set; }
            public DateTime date_created { get; set; }
            public DateTime last_modified { get; set; }
            public int amount_refunded { get; set; }
        }

        public class Collector
        {
            public int id { get; set; }
            public string email { get; set; }
            public string nickname { get; set; }
        }

        public class Payer
        {
            public int id { get; set; }
            public string email { get; set; }
        }

        public class Item
        {
            public string id { get; set; }
            public string category_id { get; set; }
            public string currency_id { get; set; }
            public string description { get; set; }
            public object picture_url { get; set; }
            public string title { get; set; }
            public int quantity { get; set; }
            public double unit_price { get; set; }
        }

        public class Element
        {
            public int id { get; set; }
            public string status { get; set; }
            public string external_reference { get; set; }
            public string preference_id { get; set; }
            public List<Payment> payments { get; set; }
            public List<object> shipments { get; set; }
            public List<object> payouts { get; set; }
            public Collector collector { get; set; }
            public string marketplace { get; set; }
            public string notification_url { get; set; }
            public DateTime date_created { get; set; }
            public DateTime last_updated { get; set; }
            public object sponsor_id { get; set; }
            public int shipping_cost { get; set; }
            public double total_amount { get; set; }
            public string site_id { get; set; }
            public double paid_amount { get; set; }
            public int refunded_amount { get; set; }
            public Payer payer { get; set; }
            public List<Item> items { get; set; }
            public bool cancelled { get; set; }
            public string additional_info { get; set; }
            public object application_id { get; set; }
            public string order_status { get; set; }
        }
        
    }
}
