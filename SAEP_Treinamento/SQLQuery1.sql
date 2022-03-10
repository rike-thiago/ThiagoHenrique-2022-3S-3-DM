BULK INSERT Comentarios
FROM 'C:\Users\47760581890.INFOSCS\Desktop\SAEP_Treinamento\Assets\Dados_Importacao\comentarios.csv'
WITH (
	FIELDTERMINATOR = ';',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 2,
	CODEPAGE = 'acp'
);