# Log Stack

Stack para armazenamento de logs.

Exemplo baseados nos projetos:

- EnterpriseApplicationLog: [GIT](https://github.com/docker-gallery/EnterpriseApplicationLog) / [Blog](https://gago.io/blog/projetos/enterprise-application-log/)
- [docker-elk](https://github.com/deviantony/docker-elk)

## Stack

- rabbitmq:3-management-alpine
- docker.elastic.co/elasticsearch/elasticsearch-oss:7.5.0
- docker.elastic.co/kibana/kibana-oss:7.5.0
- docker.elastic.co/logstash/logstash-oss:7.5.0
- docker.elastic.co/beats/metricbeat-oss:7.5.0

## Fluxo

- postar json na fila do Rabbit
- criar indice no Kibana

## Sampels

```json
{
    "type": "Error",
    "message": "Test error",
    "exception": {
        "class": "System.Exception",
        "stackTrace": "xxxxxxxx"
    },
    "session": {
        "user" : 111,
        "empresa": 1
    },
    "data": {
        "host": "vm-001"
    }
}
```
