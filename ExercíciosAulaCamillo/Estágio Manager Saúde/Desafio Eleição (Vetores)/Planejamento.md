## Enunciado

"Faça um programa que leia o número de candidatos e o número de eleitores para um sistema de votação. Esse programa deve permitir ao usuário informar o número de cada candidato (número para votação) e, em seguida, deve começar a solicitar o voto de cada eleitor. Ao término do programa, imprima o número de votos recebido por cada candidato."

### Sem usar classes (Rascunho)

ler número de candidatos

ler número de eleitores

criar vetor int de número de candidatos

inserir número dos candidatos no vetor (loop)



iniciar votação

criar vetor int votosrecebidos

comparar o número inserido com os números dos candidatos (que estão no primeiro vetor)

retornar a posição e inserir +1 na mesma posição do vetor de votos recebidos

imprimir o número de votos recebidos por cada candidato



existe um vetor com todos os números dos candidatos

cada candidato corresponde a uma posição

o eleitor escolhe um número, que deve ser procurado no vetor de números dos candidatos

em seguida, deve-se retornar a posição do candidato daquele número

adicionar 1 à posição do candidato no vetor votosRecebidos.



### Usando classes 

#### Candidato

| Propriedade/Método       | Tipo     | O que faz | Visibilidade                                    |
| ------------------------ | -------- | ------------------------------------------------------------ | ------------------------------------------------------------ |
| Nome                     | `string` | registra o nome do candidato                                 |private|
| Numero                   | `int`    | registra o número do partido                                 |private|
| QuantidadeVotosRecebidos | `int`    | registra quantos votos o candidato recebeu em uma determinada eleição |private|

#### Eleição

| Propriedade/Método  | Tipo          | O que faz                                                    |
| ------------------- | ------------- | ------------------------------------------------------------ |
| Eleicao             | construtor    | recebe qtdCandidatos e qtdEleitores.                         |
| QtdCandidatos       | `int`         | registra quantos candidatos participam da eleição            |
| QtdEleitores        | `int`         | registra quantos eleitores vão votar                         |
| Candidatos          | `Candidato[]` | registra objetos Candidato                                   |
| PreencheVotos       | `void`        |                                                              |
| RankingVencedores() | `Candidato[]` | ordena os candidatos por ordem crescente de votos recebidos  |
| ImprimeRanking()    | `void`        | imprime os candidatos, seus números e a quantidade de votos recebidos |

#### Votar

| Propriedade/Método    | Tipo   | O que faz                                                    |
| --------------------- | ------ | ------------------------------------------------------------ |
| eleicao.colherVotos() | `void` | loop que solicita ao usuário a inserção do voto (número). Chama o eleicao.PreencheVotos() |

#### Program

| Propriedade/Método   | Tipo | O que faz |
| -------------------- | ---- | --------- |
| RegistraCandidatos() |      |           |
|                      |      |           |






