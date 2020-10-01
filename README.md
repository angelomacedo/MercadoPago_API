# Mercado Pago

Módulo de testes desenvolvido para auxiliar desenvolvedores na integração com a API do Mercado Pago.


## O que será preciso para funcionar

```bash
Necessário importar as referências                       
             * Newtonsoft                                
             * RestSharp   
             
   using Newtonsoft.Json;
   using RestSharp;             
             
 Necessário configurar:                                  
             * access_token                              
             * fixed_amount = true (para fixar o valor)  

 Configurar as variáveis globais para testes
        public string token = "APP_USR-...";
        public string collector_id = "...";
        public string external_id = "PDV...";
             
             
```

## Licença
Livre para desenvolvedores.
