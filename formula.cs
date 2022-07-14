data = List.Dates(#date(1900,1,1), Number.From(DateTime.LocalNow())- Number.From(#date(1900,1,1)) ,#duration(1,0,0,0))

# CONCATENADOR 
Teste = BaseFuncionarios[Ferias Acumuladas] &"  "& BaseFuncionarios[Horas Extras]  

# Teria que atender as duas situações "E"
Teste = BaseFuncionarios[SalarioTotal] > 10.000 && BaseFuncionarios[Horas Extras] > 30 

Teste = BaseFuncionarios[SalarioTotal] > 10.000 || BaseFuncionarios[Horas Extras] > 30 ==> Teria que atender a pelo menos uma situação "OU"

teste = BaseCargos[COD Área] IN {"JAJ", "LOI"} => Identifidando a existência de mais de um valor na coluna 

# Encontrado posições com formula dax
CO Funcionario = LEFT(BaseFuncionarios[Codigos],2) -> Pega os 

# Encontrado posições com formula dax
SepEsquerda = LEFT(BaseFuncionarios[Codigos], search("-", BaseFuncionarios[Codigos])-1)

Para extrair o ano de uma data 
YEAR(COLUNA)

#Gerando calendário automaticamente com DAX 
Calendario = CALENDARAUTO()

#Extradindo os anos da base de calendários 
Ano = Calendario[Date].[Ano]

#Buscando as datas do início do mês 
Inicio do Mes = STARTOFMONTH(Calendario[Date])


#Extraindo o inicio do mes da base calendário 
Inicio do Mes = STARTOFMONTH(Calendario[Date])

#Buscando o valor do mesmo mês no ano anterior 
Valor Mes Ano Anterior = calculate(sum(BaseVendas[Valor Pedido]),dateadd(Calendario[Date], -1, year))

#Crescimento comprando com o mês anterior 
Crescimento no mes anterior = (BaseVendas[Faturamento iTotal]-[Faturamento do Mes Anterior])/[Faturamento do Mes Anterior]