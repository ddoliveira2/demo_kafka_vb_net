Imports System.Threading
Imports Confluent.Kafka

Public Class HelperKafka
    Public Shared Async Function SendMessage(topic As String, message As String) As Task

        Using producer = KafkaConnection.GetProducer()

            Dim result = Await producer.ProduceAsync(
                topic,
                New Message(Of String, String) With {
                    .Key = Guid.NewGuid().ToString(),
                    .Value = message
                }
            )

            Console.WriteLine("Mensagem enviada!")
            Console.WriteLine("Topic: " & result.Topic)
            Console.WriteLine("Partition: " & result.Partition.ToString())

        End Using

    End Function

    Public Shared Sub StartListening(topic As String, groupId As String
   )

        Dim config As New ConsumerConfig With {
            .BootstrapServers = "localhost:9092",
            .GroupId = groupId,
            .AutoOffsetReset = AutoOffsetReset.Earliest,
            .EnableAutoCommit = True
        }

        Using consumer As IConsumer(Of String, String) =
            New ConsumerBuilder(Of String, String)(config).Build()

            consumer.Subscribe(topic)

            Console.WriteLine("Aguardando mensagens...")

            While True

                Try

                    Dim result = consumer.Consume(
                        CancellationToken.None
                    )

                    Dim message As String = result.Message.Value

                    Console.WriteLine("Topic: " & result.Topic)
                    Console.WriteLine("Key: " & result.Message.Key)
                    Console.WriteLine("Mensagem: " & message)

                Catch ex As ConsumeException

                    Console.WriteLine(ex.Message)

                End Try

            End While

        End Using

    End Sub
End Class
