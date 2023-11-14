# Desafios Bootcamp .NET - DIO | WEX
Resolução de todos os desafios de código do bootcamp de .NET WEX, da DIO

## 1º Desafio: Entrada e tipos de dados:
- **Descrição:**
Neste desafio, vamos criar um programa que simula um algoritmo para registrar falhas em testes de um sistema. O programa solicitará ao usuário que insira o nome do teste e a descrição do erro correspondente. Em seguida, ele exibirá uma mensagem do erro formatado.

- **Entrada:**
A entrada do programa consiste em duas strings. A primeira string deve conter o nome do teste que falhou, e a segunda string deve conter a descrição do erro ocorrido durante o teste.

- **Saída:**
A saída do programa consiste em uma string formatada da seguinte maneira:
"O teste falhou: Descrição do erro: [descricaoDoErro]"

## 2º Desafio: Variáveis com C#:
- **Descrição:**
Neste desafio, seu objetivo é criar um algoritmo que avalie o desempenho de testes automatizados. O algoritmo deve receber como entrada o número de testes automatizados bem-sucedidos e o número total de testes automatizados realizados. Com base nessas informações, ele determinará a taxa de sucesso do teste.

- **Critérios da taxa:** Taxa de Sucesso = (Número de Testes Automatizados Bem-sucedidos / Número Total de Testes Automatizados Realizados) * 100

- **Entrada:**
A entrada consiste em dois números inteiros: o número de testes automatizados bem-sucedidos e o número total de testes automatizados realizados.

- **Saída:**
A saída é uma string que informa a porcentagem ( taxaSucesso) da taxa de sucesso dos testes automatizados, indicando se a funcionalidade testada está estável. A saída deve considerar duas casas decimais para essa solução.

## 3º Desafio: Tipos e Operadores Aritméticos:

- **Descrição:**
Neste desafio de código, você será encarregado de criar um programa que avalia a prontidão de uma funcionalidade com base nos resultados de um conjunto de testes. O programa solicitará ao usuário que insira a quantidade de testes bem-sucedidos e a quantidade total de testes realizados. Em seguida, o programa calculará a taxa de sucesso dos testes e aplicará os seguintes critérios para determinar se a funcionalidade está pronta para ser lançada:

    * Se a taxa de sucesso for maior ou igual a 80%, o programa exibirá a mensagem "A funcionalidade esta pronta para lancamento."
    * Caso contrário, se a taxa de sucesso for menor que 80%, o programa exibirá a mensagem "A funcionalidade nao esta pronta para lancamento."

    * Lembre-se de que a taxa de sucesso é calculada como a proporção de testes bem-sucedidos em relação ao total de testes, usando a fórmula: 
taxaSucesso = (double)testesBemSucedidos / testesTotais.

- **Entrada:**
A entrada consiste em dois números inteiros separados por quebras de linha. O primeiro número representa a quantidade de testes bem-sucedidos, e o segundo número representa a quantidade total de testes realizados.

- **Saída:**
O programa exibirá uma mensagem que indicará se a funcionalidade está pronta para o lançamento ou não, de acordo com os critérios mencionados acima.

