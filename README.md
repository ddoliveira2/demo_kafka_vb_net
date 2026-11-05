# demo_kafka_vb_net

Projeto demonstrativo de integração entre aplicações VB.NET e o Apache Kafka, explorando publicação e consumo de mensagens em uma arquitetura distribuída orientada a eventos.

## Sobre o Projeto

Projeto demonstrativo de integração entre aplicações VB.NET e o Apache Kafka, explorando publicação e consumo de mensagens em uma arquitetura distribuída orientada a eventos.

## Tecnologias Utilizadas

- VB.NET
- .NET Core
- Confluent.Kafka Client Library
- Apache Kafka
- Docker

## Funcionalidades

- Publicação de mensagens por meio de Producer
- Consumo contínuo de mensagens por meio de Consumer
- Utilização de tópicos Kafka
- Serialização e tratamento de payloads, conforme implementado

## Arquitetura do Projeto

Arquitetura orientada a eventos (Event-Driven Architecture), utilizando o modelo Publisher/Subscriber. Produtores publicam mensagens em tópicos e consumidores processam essas mensagens por meio do broker Kafka.

## Banco de Dados

Não utiliza banco de dados relacional como requisito central. As mensagens são gerenciadas pelo Apache Kafka, que mantém os dados nos tópicos conforme sua configuração.

## Como Executar

1. Clone este repositório.
2. Verifique os requisitos de .NET e Docker utilizados pelo projeto.
3. Inicie uma instância do Apache Kafka. Se houver arquivo Docker Compose no repositório, utilize a configuração fornecida nele.
4. Configure o endereço do broker e os nomes dos tópicos utilizados pela aplicação.
5. Restaure os pacotes NuGet, compile e execute os projetos Producer e Consumer conforme a estrutura do repositório.
6. Envie mensagens pelo Producer e acompanhe o processamento no Consumer.



## Aprendizados

- Conceitos de mensageria distribuída.
- Publicação e consumo de eventos com Kafka.
- Padrão Producer/Consumer e arquitetura Pub/Sub.
- Integração de aplicações VB.NET com infraestrutura em Docker.

## Autor

**Daniel**

- GitHub: https://github.com/ddoliveira2
- LinkedIn: https://www.linkedin.com/in/daniel-donizete-7a9a7292/

## Licença

Este projeto está disponibilizado para fins de estudo e demonstração de conhecimentos. Caso deseje definir uma licença de uso, adicione aqui o arquivo e os termos correspondentes.
