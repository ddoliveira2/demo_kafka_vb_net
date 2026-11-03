Imports Confluent.Kafka
Public Class KafkaConnection
    Private Shared _config As New ProducerConfig With {
       .BootstrapServers = "localhost:9092"
   }

    Public Shared Function GetProducer() As IProducer(Of String, String)

        Return New ProducerBuilder(Of String, String)(_config).Build()

    End Function
End Class
