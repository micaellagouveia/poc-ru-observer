# POC ReceivableUnit (Padrão Observer)

Para fins de estudo do padrão observer, criei essa POC usando o contexto de contratos da RU como exemplo.

Para exemplificar o uso do padão, foram criados:
- Contract: É o subject, o assunto, aquele que trará as atualizações em forma de mensagem para aqueles que se inscreverem na sua lista de transmissão.
- ReceivableUnit: É o observador, ele se inscreve no assunto que deseja para receber suas atualizações

O Contract envia atualizações de contratos por documento, e cabe a RU receber essa mensagem e fazer o tratamento necessário para que ela possa ser usada em seu contexto. No caso, a RU soma os valores uncommited para ter a soma de valores disponíveis por UR daquele documento.
