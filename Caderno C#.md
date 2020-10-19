# Bem vindo ao meu caderno

- **As coisas ficam mais legais a partir da *aula 9***

- **Veja os códigos das aulas na pasta [CFB](CFB/)**

  Otávio Dioscânio /2020

  

OS - Windows - Microsoff.Net - Framework64 - csc.exe

- csc.exe é o compilador C#
- pesquisar csc no prompt: mostra se está no path do sistema (provavelmente não vai estar). Logo, deve-se baixar o .Net SDK, o .Net Framework DevPack, o .Net Runtime
- Programação orientada a objetos: todo programa me C# é uma classe
- dir: revela o que está na pasta
- apenas digitar o nome do arquivo para executá-lo
- Compilar no prompt: csc Aula01.cs
- Abrir uma pasta: cd Aula01
- cls limpa o prompt

`using System;`
`class Exercicio1 {`
`static void Main() {`
`Console.WriteLine("Olá mundo!");`
`}`
`}`

__________________________________________________________________
### Aula 2

Padrão dotnet: interface similar à JVM, para rodar em vários dispositivos
Namespace organiza as classes

__________________________________________________________________
### Aula 3 - Variáveis

- int num;	//deixa ele como 0
- Declaração e atribuição
- primitivas: int, char, float, byte
	`float valor = 3.2f`
	`byte n1 = 10; // entre 0 e 255, não tem sinal. 8 bits`
- String não é primitiva

	`var numero = 10; //quando não quiser especificar o tipo. É atribuído na compilação`

	`int num1=0, num2=0;`

____________________________________________________________________
### Aula 4 - Escopo de variáveis

- Onde ela é visível, pode ser utilizada 
____________________________________________________________________
### Aula 5 - Operadores

`bool res = 10 < 5; 	// False`

###### Incrementar

`num = num + 1;`
`num += 1;	num *= 2;`
`num++;	// só funciona para somar 1``
`

###### & e |

`bool res = (5 > 3) | (10 < 5);`

___________________________________________________________________
### Aula 6 - Formatando a saída no console

- Lembrando que Console.WriteLine(); quebra linha.
- Em vez de concatenar, utilizar índices a partir do 0.
- \n quebra linha
- \t insere um tab
- `Console.WriteLine("Val.Compra...:{0,15:c}", valorCompra);`
- c: valor monetário, p: porcentagem.
_____________________________________________________________________
### Aula 7 - Constantes

- Uma vez atribuído um valor, ele não pode modificar (senão dá erro). 
- Tipo uma proteção para a variável.
- Palavra reservada: const.
- O restante é igual às variáveis.

`const string canal = "CFB Cursos";`
`const double pi = 3.1415;`

______________________________________________________________________
### Aula 8 - Lendo valores no teclado

- Console.Read() ou Console.ReadLine()
	- ReadLine quebra linha (ou adiciona uma?) depois do enter
- Cuidado: tudo que é lido vai no formato String
Duas formas de converter:

`v1 = int.Parse(Console.ReadLine());`
`v2 = Convert.ToInt32(Console.ReadLine());`

____________________________________________________________________
### Aula 9 - Operações Bitwise

<u>Bitwise para esquerda <<: dobra o valor da variável</u>
	Os cinco últimos bits vão para a esquerda, completando um 0 no final
	ex.: 001010 = 10
	     010100 = 20
<u>Para a direita >> : divide por 2</u>
	Elimina o último bit e desloca tudo para a direita
	     011010 = 26
	     001101 = 13

```c#
int num = 10;
num = num >> 1;	// desloca apenas 1 (divide apenas uma vez)
Console.WriteLine(num);	// 5 (para a direita divide)
```

di-di (direita divide)

```C#
int num = 10;
num = num << 2;
Console.WriteLine(num);	//40
```

cabo 11:49 23/09/2020

_________________________________________________________________
### Aula 10 - Enumeradores (enum)

- Criar um tipo personalizado com valores predefinidos

```C#
enum DiasSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}
DiasSemana ds = DiasSemana.Domingo;	// DiasSemana é o tipo de ds
```

- Converter o valor 3 no tipo DiasSemana

```C#
DiasSemana ds = (DiasSemana)3;	// uso de cast
Console.WriteLine(ds);	// Quarta
```

```C#
int ds = (int) DiasSemana.Sexta;
Console.WriteLine(ds);	// 5
```



__________________________________________________________________
### Aula 11 - Conversão de tipo (typecast)

- Quando a conversão não é implícita/segura
- Não serve quando precisa de int.Parse ou Convert.ToInt32

- Conversões implícitas:
	int -> float, int -> long

```c#
int n1 = 10;`
float n2 = n1;	// converte automaticamente
Console.WriteLine(n2);
```

```c#
float n2 = 10.5f;
int n1 = n2;	// float -> int não tem conversão implícita, mas existe a explícita
```

```c#
float n2 = 10.5f;
int n2 = (int) n1;	// typecast, explícita.

int vInt = 10;
short vShort = (short) vInt;	// cuidado
```



_________________________________________________________________
###### Aula 12 - condicional if

###### Aula 13 - if, else if, else

- lembrar que pode mudar a ordem e que não precisa de duas expressões no condicional

###### Aula 14 - if aninhados: if dentro de outro

_________________________________________________________________
### Aula 15 - Switch case

- Compara uma variável com seus cases
``` c#
int tempo = 0;
char escolha;
escolha = char.Parse(Console.ReadLine());

switch (escolha) {
case 'a':
case 'A':	// testa os dois
    tempo = 50;
    break;	// faz parte da estrutura padrão do case
case 'c':
    tempo = 480;
    break;
case 'o':
    tempo = 660;
    break;
default:
    tempo =-1;
    break;
}

switch (variavelIndicada) {case}
```
- Dúvidas: o default é obrigatório? 

### Aula 16 - Comando GoTo

- Antigo, de uma época em que não existiam estruturas de repetição (programação em fluxo, e não estruturada que nem hoje).
- Pode ser útil e tornar o código legível (ex.: loops profundamente aninhados)
- Gera um desvio no programa para um ponto determinado
-  Cuidado, ele pode criar loops invisíveis

```c#
inicio:	// label
...
goto inicio;

while: if x >= 10 goto end
    print x
    x++
    goto while
end:

tryAgain:
    try {
        ...
    } catch (...) {
        goto tryAgain;
    }

return !(cond1 || cond2 || cond3);
```


______________________________________________________________________
### Aula 17 - Arrays unidimensionais (vetores)

- Coleção de variáveis do mesmo tipo
- tipo, colchetes nome recebe new tipo [tamanho];
- Mais fácil para criar, atribuir e ler variáveis
  	

```c#
int[] meuArray = new int [5]; // 0-4

meuArray[0] = 111;
meuArray[1] = 200; meuArray[3] = 400; meuArray[4] = -20;

Console.WriteLine(meuArray[0]); // 111

string[] veiculos = new string[3];
```

- Já atribuindo na declaração

```c#
int[] numeros = new int[3] {55, 77, 99};
Console.WriteLine(numeros[2]); // 99
```

- Também dá:

```c#
int[] num = {55, 77, 99, 66, 88}; // não fica com tamanho limitado.
```

- dúvida: não colocar o new tipo[tamanho] deixa o vetor dinâmico? Posso adicionar elementos após a criação?

___________________________________________________________________
### Aula 18 - Arrays bidimensionais (matrizes)

- Utiliza dois índices para localizar os elementos

- É como se fosse uma tabela, índices de linha e coluna
- No operador (colchetes) coloca-se uma vírgula
- Os índices podem ter tamanhos diferentes

```c#
int [,] n = new int [3,5];	// linha, coluna

	/*
	10 20 30 40 50
	60 70 80 90 15
	25 35 45 55 65
	*/

n[0,0] = 10; n[0,1] = 20; n[0,2] = 30; n[0,3] = 40; n[0,4] = 50;
n[1,0] = 60; n[1,1] = 70; n[1,2] = 80; // ...
n[2,0] = 25; n[2,1] = 35; // ...

int [,] num = new int [2,2] {{10,20}, {30,40}}; // primira linha, segunda linha
```


___________________________________________________________________
### Aula 19 - Loop FOR	

```C#
for (int num = 0; num < 10; num + 1) {}

// declarar internamente: num só serve no escopo do for.
// enquanto a condição for verdadeira, ele vai executar
// obs.: ele começa e imprimir no 0 e vai até o 9, passando por 10 números
	
int[] num = new int[10];
for (int i = 0; i < num.Length; i++) {
	num[i] = i;
}
```
- `num.Length` - tamanho do array (não é o último índice)
- for é geralmente usado quando se tem certeza das vezes que o comando será repetido

___________________________________________________________________

### Aula 20 - While

 - Inicialização e atribuição do contador **antes** do while
- Operação de incremento dentro

```C#
int [] num = new int[10];
int i = 10;
while (i > 0) {
	Console.WriteLine(i);
	i--;
} // 10-1
```
- Lembre-se que a última posição de um array é array.Length - 1


____________________________________________________________________
### Aula 21 - Do While

- Garante-se que, pelo menos uma vez, os comandos serão executados

```C#
do {
	Console.WriteLine(i);
	i++
} while (i < 5);

string senha = "123";
string senhauser;
int tentativas = 0;

do {
	Console.Clear();
	Console.WriteLine("Digite a senha");
	senhauser = Console.ReadLine();
	tentativas++
} while (senhauser != senha);

Console.WriteLine("Senha correta. Tentativas: {0}", tentativas);
```

- obs.: Console.ReadKey();

___________________________________________________________________
### Aula 22 - Loop FOREACH

- Próprio para ler elementos de uma coleção
- Cria uma variável que vai receber cada elemento da coleção (logo, precisa ser do mesmo tipo)

```c#
int [] num = new int[5]{11, 22, 33, 44, 55};

foreach(int n in num) {

	Console.WriteLine(n);	// coloca os valores no n. Não tem contador
	
}
```

- Não é possível atribuir valor a n dentro do foreach (??)

______________________________________________________________________
### Aula 23 - Métodos para arrays

- <u>Legenda</u>: vetor = um array qualquer

```c#
Random aleatorio = new Randow();	// classe Random, objeto aleatorio

int valor = aleatorio.Next(50);
int valor1 = aleatorio.Next(-5, 250);
```

```C#
int tamanho = vetor.Length;
```
```c#
foreach (int elemento in vetor) { }
```

```c#
Array.BinarySearch (vetorPesquisa, valorProcurado);
```
- retorna a posição. O array precisa estar ordenado (?). Caso não exista, retorna negativo.


```c#
Array.Copy(vetorOrigem, vetorDestino, quantidadeElementos);
```
- quantidadeElementos conta a partir do 0?


```c#
vetorOrigem.CopyTo(vetorDestino, posicaoInicial);

vetor1.CopyTo(vetor3, 0);
```


```c#
vetor.GetLowerBound(dimensão);
vetor.GetUpperBound(dimensão);
```
- retorna o menor/maior índice do vetor ou matriz (?)

```c#
vetor.GetValue(indice);
```
- retorna object. indice é long. também serve para matriz


```c#
Array.IndexOf(vetor, valor);
```
- posição da primeira ocorrência. -1 se não existir. somente para vetor unidimensional.


```c#
Array.Reverse(vetor);

vetor.SetValue(object valor, long indice);

Array.Sort(vetor);
```

---

### Aula 24 - Métodos

- Métodos são conjuntos de instruções, um bloco que pode ser invocado a qualquer momento;
- Void: não retorna
- É static pois o método principal também é
- Os argumentos não precisam ser do mesmo tipo

---

### Aula 25 - Passagem por valor e referência

- ##### Passagem por referência:

```C#
static void Main() {
    int num = 10;
    dobrar(ref num);	// ref na hora de passar
    Console.WriteLine(num); // 20
}
static void dobrar(ref int valor) { // ref no método
    valor *= 2;
}
```

- A variável passada por parâmetro com ref entra no método, executa o código, e sai como se fosse global.
- <u>Cuidado</u>: passagem por referência afeta variáveis, mesmo não havendo o `return`
- `valor` aponta para o endereço de memória de `num`
- Tem que usar o ref também na hora de chamar o procedimento e passar o parâmetro

---

### Aula 25 - Argumento *out*

- Possibilidade de o método ter mais de um valor de saída

```C#
static void Main() {
    int divid, divis, quoci, rest;
    dividendo = 10;
    divisor = 5;
    quoci = divide (divid, divis, out rest); // tem que usar o out aqui também
    Console.WriteLine(...) 
   
}

static int divide (int dividendo, int divisor, out int resto) {
    int quociente = dividendo / divisor;
    return quociente;
}

// return quociente, resto; -> não existe!!

```

> out rest
>
> out int resto

- pelo visto você cria uma variável vazia que vai entrar no método só para receber um valor e voltar.

### Aula 27 - Argumento *params*

- Não precisa especificar o número de argumentos, pode ser 0 ou n.
- Deve-se colocar uma forma de controle (ex.: if, else if) dentro do método

```C#
static void Main() {
    soma (10, 7, 8, 1, 4, 2);
    soma ();
    soma (1, 2);
}

// ---- jeito limitado (aceita até 2 parâmetros):

static void soma (int n1, int n2) {
    int res = n1 + n2;
    Console.WriteLine("A soma é " + res);
}

// --- com params - permite zero ou mais:

static void somaFlexivel (params int[] nomeArray) {
    int res = 0;
    if (nomeArray.Length < 1) {
        Console.WriteLine("Não existem valores para somar")
            
    } else if (nomeArray.Length < 2) {
        Console.WriteLine("Valores insuficientes");
        
    } else {
        for (int i = 0; i < nomeArray.Length; i ++) {
            res += nomeArray[i];
        }
        
    }
    
}
```

---

### Aula 28 - Classes e Objetos

- Classe: tipo de dado composto por membros (variáveis e métodos/funções da classe).

  - Onde vão ser instanciados os objetos. É a base, define o comportamento deles.

  - Objetos são independentes entre si, são instanciados em lugares diferentes da memória

```C#
[ModificadorClasse] class NomeDaClasse {
     // variáveis / propriedades
    [EspecificadorAcesso] tipo NomePropriedade;
    
    // métodos
    [EspecificadorAcesso] retorno NomeMetodo([arg1, ...]) {
        // corpo do método
    }
}
```

- <a id="Tipos Classe">ModificadorClasse:</a>

  - **public**: pública, sem restrição de visualização ou acesso em qualquer parte do programa. Não é o padrão se for omitido (e sim internal).

  - **abstract**: classe-base para outras classes, não pode gerar objetos.

  - **sealed**: selada, dela não pode haver herdeiros

  - **static**: não pode ser instanciada, mas é possível acessar seus membros, que também devem ser estáticos.

    - tudo que vai ser usado no construtor (Main)  static deve ser static também.

    

- EspecificadorAcesso:

  - **public**: sem restrição de acesso - qualquer membro, inclusive fora da classe, sem um método para isso. É o padrão.
  - **private**: só podem ser acessados pela própria classe. É o padrão.
  - **protected**: acessado na própria classe e nas classes derivadas (herança)
  - **abstract**: só há a implementação do cabeçalho do método, não a definição dele (que fica no bloco de código).
    - Obriga a implementação do método na classe que está herdando da classe pai
  - **sealed**: o método não pode ser redefinido
  - **virtual**: o método pode ser redefinido em uma classe derivada
  - **static**: o método pode ser chamado mesmo sem instanciar um objeto
    - pode usar o membro static sem precisar do <u>New</u> para instanciar

  

- Futuramente: métodos construtores, destrutores

- Boa prática: nome da classe com letra maiúscula.

- Obs.: ainda não sei os defaults de class, main, variáveis

-  As classes e estruturas por padrão são `internal`, já os membros de classe/estrutura são privados por padrão.

- `new`: vai alocar a memória para um objeto e retornar o endereço dela

```C#
public class Jogador {
    public int energia = 100;
    public bool vivo = true;
}

public class Aula28 {
    
    static void Main() {
        
        Jogador j1 = new Jogador(); // criou o objeto j1 da classe Jogador
        Jogador j2 = new Jogador(); // instanciamento sem parâmetros
        Jogador j3 = new Jogador();
        
        j1.energia = 50;
        
        Console.WriteLine("Energia do jogador 1: {0}.", j1.energia);
        Console.WriteLine("Energia do jogador 2: {0}.", j2.energia);
        
       // 50, 100 (são independentes)                
    }
}
```

---

### Aula 29 - Construtores e Destrutores

- <u>Método construtor</u>: atua no objeto quando instanciado, tem a função de inicializar as propriedades/variáveis.
- Toda classe tem um construtor, mesmo que não seja explícito
- Basta que o método tenha o mesmo nome da classe 

```C#
public class Jogador {
    
    int energia; bool vivo;
    
    public Jogador() {	// método construtor
        
        energia = 100;
        vivo = true;
        
    }
}
```

- É possível passar parâmetros para o Construtor da classe

```C#
public class Jogador {
    
    int energia; bool vivo;
    String nome;
    
    public Jogador(String n) {
        
        energia = 100; vivo = true;
        nome = n;
        
    }
}
```

- Aí precisa colocar o nome ao instanciar:

```C#
Jogador j1 = new Jogador("Zenifreudo");	// ou zigofreudo
```

- <u>Método destrutor</u>: chamado antes de o objeto ser destruído pelo *garbage collector*. 
  - Não precisa definir visibilidade. Apenas um **~** seguido do nome da Classe.

```C#
		nome = n;	// continação, ainda dentro de classe
	}

	~Jogador() {	

		Console.WriteLine("Jogador foi destruído");

	}
```

---

### Aula 30 - Sobrecarga de construtores

- Permite mais um construtor para a classe.
- Vários construtores de mesmo nome, <u>mas o conjunto de parâmetros é diferente</u>.
- Obs.: sobrecarga de métodos é mesma coisa

```c#
public Jogador () { }
public Jogador (string n, int e) { }
	// etc

Jogador j1 = new Jogador();
Jogador j3 = new Jogador ("Théo", 50);
	// etc
```

---

### Aula 31 - Classes Estáticas

- <u>Não se pode instanciar a partir de uma classe declarada como static.</u>
- Logo, <u>classes static não permitem o uso de construtores</u>. O objeto static utiliza uma posição fixa na memória, não se usa `new`.

```c#
static public class Jogador {

	static public int energia;	// todos os membros são static também
	static public bool vivo;
	static public string nome;
    
	static public void iniciar (string n) {	// propriedades
        
		energia = 100;
		vivo = true;
		nome = n;
        
	}
	//...
}
```

- Todos os membros (propriedades e métodos) são obrigatoriamente static também.
- Classe disponível em todo o programa sem precisar instanciar um objeto.

```c#
class Aula31 {

static void Main () {
    
    	Jogador.iniciar("Otávio");	// acessa-se pela própria classe
		Jogador.info();
}
} 
```

- A chamada é pela própria classe static, não há objetos (j1, j2, j3...)
- Alterar uma propriedade da classe: surte efeitos em todo o sistema, pois o local da memória que todos acessam é fixo e comum.

#### Classe não static

- Pode ter objetos.
- Uma classe não static <u>pode ter</u> um membro static, mas não é obrigatório.
  - Neste caso, todos os objetos da classe vão apontar para a mesma propriedade, eles não terão uma própria.
  - Não é possível modificar individualmente.
- Sem propriedade static:

```C#
class Inimigo {

	public bool alerta;	// não é static
	public string nome;

	public Inimigo(string n) {
		alerta = false;
		nome = n;
	}
    //...
}

class Aula31 {

static void Main () {
    Inimigo i1 = new Inimigo("Doido");
	Inimigo i2 = new Inimigo("Maluco");
    
    i1.alerta = true;	// funciona pois alerta não é static
    //...
}
```

- Com `alerta` static: 

```C#
class Inimigo {
    
	static public bool alerta;
    public string nome;
    
    //...
```

```c#
static void Main () {
    Inimigo i1 = new Inimigo("Doido");
	Inimigo i2 = new Inimigo("Maluco");
    
	Inimigo.alerta = true; // e não: i1.alerta = true;
    
	i1.nome = "oi"; // pode pois nome não é estático
}
```



---

### Aula 32 - Operador This

- Faz referência à propriedade da classe, e não do método. Ao objeto pai

```C#
class Calculos {
	public int v1; // esse daqui é representado pelo this
	public int v2;
	
	public Calculos (int v1, int v2) {
		/*v1 = v1;
		v2 = v2;*/
     
		this.v1 = v1;
		this.v2 = v2;
    }
```



---

### Aula 33 - Public vs Private

- Propriedades `private` são inacessíveis fora da classe.
- Proteção aos membros: não dá para mudar/acessar sem um método público que permita.
  - define-se, inclusive, os valores aplicáveis à variável, se fosse `public` qualquer valor seria aceito.
  - filtro do valor a ser atribuído

---

### Aula 34 - Herança

- É um recurso da POO em que uma **classe derivada** (filha) herda membros, propriedades e classes de uma **classe base** (pai) 
- Evidentemente, a classe derivada pode ter seus membros próprios
- Importante: só herda o que for `public`

- Uma classe derivada tem o nome da classe base depois de dois pontos

```c#
class Carro:Veiculo {
```

- Pode ter espaço entre os dois

---

### Aula 35 - Cadeira de herança e Construtor da classe base

- O construtor da classe filha pode passar parâmetros para o construtor da classe base e executá-lo.

```C#
class Veiculo {						// classe base
	public Veiculo (int rodas) { 	// construtor
```
- Construtor da classe derivada:

```c#
class Carro: Veiculo {				// classe derivada
    //...
	public Carro(string nome, string cor):base(4) {
```

- `base()` é palavra reservada que, neste caso, se refere ao construtor da classe pai

##### Cadeia de herança

- Imagine uma outra classe que herda Carro (que já herda Veículo)

```c#
class CarroCombate:Carro {
	public int municao;
    
    public CarroCombate():base("Carro de batalha", "verde") {
		municao = 100;
		ligar();
		setRodas(6);
    }
}
```
- Na hora de instanciar: 

```c#
CarroCombate cc1 = new CarroCombate();
```

##### Operador ternário

```c#
return (ligado ? "sim" : "não");

([expressão] ? [valor1] : ([expressão] ? [valor1] : ([expressão] ? [valor1] : [valor2])))
```

- Não pode ficar sem o `else`, nem colocar `null` no lugar dele.



---

### Aula 36 - Membros Protected

- <u>Private</u>: restringe à classe. Só é possível acessar de fora por métodos (públicos) da própria classe.

  - Classe derivada não tem acesso

- <u>Protected</u>: é igual ao private, mas permite acesso também pelas classes derivadas


---

### Aula 37 - Herança: ordem de execução dos construtores

- Ao instanciar um objeto de `Derivada2`, todos os construtores serão executados.	
- **A ordem de execução de construtores é sempre da base para a derivada.**
- No código, base -> derivada1 -> derivada2

---

### Aula 38 - Métodos Virtuais

- São métodos que têm o mesmo nome mas estão em classes diferentes, sendo que uma herda a outra
- Executam uma ação diferente

- **Virtual**: será sobrescrito em uma classe derivada
- **Override**: vai sobrescrever em uma classe derivada

```c#
virtual public void info() { // quem é virtual pode ser sobrescrito

}
// ...

override public void info() { // sobrescreve

}
// ...

override public void info() { // classe mais específica, sobrescreve 

}

deriv2.info();
```

- Não precisa codificar o método virtual, já que ele não será executado, deixe o espaço entre chaves vazio (não precisa de definições, só da assinatura)

- Percebi que usar as palavras `virtual` ou `override` só evitar warnings, mas o código compila sem elas.

##### Ref

```C#
Base Ref;
Ref = deriv2;
Ref.info();	// "Derivada2"
```

- `Ref` tem que ser com letra maiúscula, é palavra reservada.

- Elemento de referência que pode receber as classes derivadas dessa base

---

### Aula 39 - Classes e métodos abstratos

- Classe abstrata: classe de referência/base para outras classes que vão herdar dela.
  - Não dá para instanciar objetos!
  - Não pode ser `sealed` ou `abstract`
- Em métodos abstratos, não se implementa o comportamento, cria-se apenas o protótipo que vai servir como guia para as classes herdeiras. Não há conteúdo.
  - Obriga que as classes derivadas implementem os métodos
- Métodos não abstratos: contém a implementação, que é obrigatória.
- Esqueceu? [Veja aqui](#Tipos Classe)

```c#
abstract public void aumentarPeso(int peso);
```

```c#
override public void aumentarPeso(int peso){
    this.peso += peso;
}
```

- Resumo: é um guia, obriga implementação, não tem código, usar ponto e vírgula.

---

### Aula 40 - Classes Sealed

- Classe selada: não pode ser herdada.

```c#
sealed class Comida {
```

- Dá para instanciar objetos normalmente, só não pode usá-la como base.

---

### Aula 41 - Acessors GET e SET

- Propriedade especial e flexível
- É possível ler, atribuir ou calcular pela propriedade Acessor
- Tem comportamento de método
- Não é obrigatório implementar um `get` (read) e um `set` (write) juntos
- Obs.: `value` é o valor atribuído à propriedade.

```c#
public int pes {	// não possui parâmetros
    
	get {
		return peso;
	}
    
	set {			// não confundir pes com peso!
		if (value < 0) peso = 0;
		else if (value > 200) peso = 200;
		else peso = value;
        
	}  				// set não tem return
}
```

```c#
bicho.pes = 140;	// usa o acessor set
Console.WriteLine("Peso: " + bicho.pes); // usa o get
```

---

### Aula 42 - Indexadores de Classes

- Membro de uma classe que <u>permite que os objetos</u> dela possam ser indexados como **arrays**.
- Aplicação (ex.): valores diferentes em situações diferentes
- Obs.: `this` é o que indexa
- Dúvidas: 1) onde está a referência no cabeçalho do indexador de que é o peso a ser indexado e acessado pelos objetos? 2) só pode um indexador por classe? poderia ter bicho.peso[1] e bicho.altura[2]?

```c#
private int[] peso = new int[5]{80, 120, 160, 240, 300};
```

```c#
public int this[int i] { // indexador 
		
	get {
		return peso[i];
	}

	set {	
		if (value < 0)
			peso[i] = 0;
		else if (value > 200)
			peso[i] = 200;
		else 
            peso[i] = value;
	}
}
```

```c#
Console.WriteLine("Peso: " + bicho[2]);
bicho[2] = 140;
Console.WriteLine("Peso: " + bicho[2]);
```

---

### Aula 43 - Interfaces

- **Interfaces só possuem as assinaturas dos métodos.** Não possuem propriedades, não dá para declarar ou atribuir variável, não pode ter construtor ou destrutor, não define membros static ou método operator. Muito parecido com classe [static](#Tipos Classe).

```c#
public interface Veiculo {
```

- Toda classe que usar uma interface precisa obrigatoriamente implementar seus métodos.
- Uma classe pode herdar múltiplas interfaces

```c#
class Carro:Veiculo, Combate{
```

- Se definir a herança mas não implementar: dá erro.


> error CS0535: 'Carro' não implementa o membro de interface 'Veiculo.ligar()'

- Pode ser implementado e não executar nenhum comando

```c#
public void info() {}
```

---

### Aula 44 - Struct

- Estrutura é um tipo especial que permite o armazenamento de diferentes tipos de dados. É mais simples e se parece com classe.
- Como **não é classe**, não pode herdar nem servir como base
  - Mas pode ter construtores
  - Construtor vai ser chamado desde que o operador new seja usado na instanciação do objeto (como já sabemos)

```c#
struct Carro {
```

```c#
Carro c1;				// sem chamar o construtor
c1.marca = "Nissan"		// nesse caso marca é public
```

```c#
Carro c2 = new Carro("Nissan ", "Versa rebaixado ", "Azul ");
// chamando o construtor
```

---

### Aula 45 - Array de Struct

- Quando quer criar vários objetos de um mesmo tipo (Struct é um tipo)
- Isso não serve para classes.

```c#
Carro [] concessionaria = new Carro[4];
concessionaria[0].marca = "HRV";
concessionaria[0].cor = "Prata";
```

---

### Aula 46 - Métodos que retornam objetos

**voltar nessa aula, entendi pouca coisa** :cry:	

```c#
	return new Ovo(numOvo, nomeGalinha); // chama o construtor
```

---

### Aula 47 - Sobrecarga de métodos

- Os métodos devem ter parâmetros diferentes (em número ou tipo).
- Funções de mesmo nome que fazem coisas diversas.

```c#
public double soma(params double[]n) {
		double soma = 0;
		foreach (double i in n) {
			soma += i;
		}
		return soma
}

public int soma(params int[]n) {
		int soma = 0;
		for (int i = 0; i < n.Length; i++) {
			soma += n[i];
		}
		return soma;
}
```

---

### Aula 48 - Recursividade

- Função recursiva: que chama ela mesma. Precisa-se de uma condição de parada.
- Fatorial e somatório: exemplos clássicos
- Substitui estruturas de repetição.

```c#
public int fat(int n) {
	int res;
	if (n <= 1) {
		res = 1;  // controle de parada
	} else {
		res = n * fat(n - 1); // modificação de n
	}
	return res;
}
```

---

### Aula 49 - Métodos e Variáveis Estáticos (static)

- Não estão necessariamente em uma classe static
- Acessar os métodos da classe **sem precisar declarar um objeto**.
- Podem ser chamado de qualquer lugar (se forem públicos)

```c#
class Mat {

	public static double pi = 3.14;

	public static int dobro (int n) {
		return n * 2;
	}
}
class Aula49 {
	static void Main() {
		double vPi = Mat.pi;	// propriedade
        int vinte = Mat.dobro(10); // função
    }
}

```

---

### Aula 50 - Delegates

- É um *objeto* que faz referência a métodos
- Ex.: uma classe com vários métodos `static` e um `delegate` que faz referência a eles. 
- `delegate` possui o endereço de entrada do método, não a rotina inteira
- desafio: fazer o mesmo programa com params

```c#
using System;

delegate int Op(int num1, int num2);

class Matematica {

	public static int soma(int n1, int n2) {
		return n1 + n2;
	}

	public int multi(int n1, int n2) {
		return n1 * n2;
	}
}
```

```c#
class Aula50 {
	static void Main() {
		int res;
		Op d1 = new Op(Matematica.soma);
		res = d1(3, 4);       
    }
}
```

- O que eu entendi: cria-se um objeto da "classe" delegate; ele recebe o método pelo parâmetro do construtor, comportando-se como o próprio método. (não entendi a utilidade).

---

### Aula 51 - Argumentos de entrada do programa

- Usa-se um array, que pode ter qualquer nome;

```c#
static void Main(string[] args) { // array
	if (args.Length > 0) {
			Console.WriteLine("Quantidade de argumentos: " + args.Length);
		// ...
```

- Passando os parâmetros na hora de executar:

> .\Aula051-ArgumentosEntrada oi ola sim verdade
>
> Quantidade de argumentos: 4
> oi na posição 0
> ola na posição 1
>
> //...

- Pergunta: tem que ser string? tem que ser vetor?
  - Consegui compilar com int e double, mas deu um warning. Só foi possível passar número inteiro como argumento (nesses dois casos).
  - tem que ser vetor, tentei Main(string a, string b) e deu erro.

---

### Aula 52 - Exceções (parte 1) - Try Catch 

- Exceções = erros

- Toda exceção é representada por uma classe que herda da classe `Exception`
- Em uma zona crítica, é possível definir o caminho caso dê erro (tratamento de erro)

> Exceção Sem Tratamento: System.DivideByZeroException: Tentativa de divisão por zero.
>    em Aula52.Main()

- Quando dá problema: executa o que está no `catch` **e continua a execução normal do programa**.
  - A continuação se dá **a partir do `catch`**. Atenção: se ocorrer um erro na primeira linha do `try`, as demais linhas dele não serão executadas, pois o desvio é imediato.

```c#
n1 = 10;
n2 = 0;
		
try {
	res = n1 / n2;
    Console.WriteLine("Não deu erro na linha anterior. Ufa!");
} catch {
	Console.WriteLine("ERRO!");
}
```

> ERRO!
> 10 / 0 = 0

- Gerar mensagem:
  - Recebe objeto da classe `Exception`

```c#
/...
} catch (Exception e) { // ou mais específico: DivideByZeroException e
	Console.WriteLine("ERRO! " + e.Message);
    Console.WriteLine(e);
    Console.Writeline(e.GetType)
}
```

---

### Aula 53 - Tratamento de Erros (parte 2) - Try Catch Finally

- bloco `finally`: é executado independentemente do disparo da exceção

```c#
try {
	// executado até a linha do erro
} catch {
	// só quando dá erro
} finally {
	// executado sempre
}
```

- E se eu quiser fazer minha própria exceção? Dá para forçar/criar um erro:

`throw new Exception(string message);`

```c#
try {
	res = n1 / n2; // aqui não deu erro
	Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
    
	throw new Exception ("Encontrei um erro!"); // entra no e.Message 

} catch (Exception e) {	
//...
```

- Veja no código da aula a mensagem criada em um método  de uma classe.

---

### Aula 54 - Namespaces

- Controle de escopo.
- Pode-se classificar os elementos dentro do Namespace. Agrupamento de classes por tipo.
- É possível ter duas classes ou funções de mesmo nome mas em namespaces diferentes.
  - o local/escopo é diferente
  - Na hora de chamar deve-se indicar o namespace

```c#
namespace Calc1 {
	class Area{
	}
}
namespace Calc2 {
	class Area {
	}
}
class Aula54 {
	static void Main() {
		area = Calc1.Area.Quad(0, 5F); // teve que indicar o namespace
	}
}
```

---

### Aula 55 - Coleção Dictionary

- Coleção de dados que são relacionados pelas chaves
- Quantidade de itens específica/genérica

- Tem que importar a biblioteca `System.Collections.Generic`

```c#
using System;
using System.Collections.Generic;
```
- Construtor genérico:

```c#
Dictionary <tipoChave, tipoDado> nome = new Dictionary <tipoChave, tipoDado> ();
Dictionary <int, string> veiculos = new Dictionary <int, string> ();
```

- Adicionar elementos

```c#
nomeDicionario.Add(chave, valor);
veiculos.Add(5, "Aviao");
```

- Propriedade count (não é método)

```c#
veiculos.Count; // tipo int
```

- Método clear

```c#
veiculos.Clear(); // limpa tudo
```

- Verificar se determinada chave ("posição") está preenchida: `dictionary.ContainsKey(key)`
  - Lembrar que o preenchimento do dicionário não precisa ser sequencial. Usar as chaves 10, 32 e 150 não vincula os valores ignorados. Lembrar que é um índice, não precisa ser numérico, isso aqui não é array.

```c#
if (veiculos.ContainsKey(20)){ // retorna booleano (e não o valor)
```

- Se existe um valor na coleção: `dictionary.ContainsValue(value)`

```c#
if (veiculos.ContainsValue("Navio")) { // retorna booleano (e não a chave)
```

- Remover um valor específico: método `dictionary.remove(chave)`

```c#
veiculos.Remove(20);
```

- Propriedades Keys e Values retornam coleções com chaves e valores, respectivamente. Precisa de um elemento Keycollection
- Substituir um valor (também me parece um substituto de dicionario.Add(chave, valor);

```c#
dicionario[chave] = valor;
veiculos[15] = "Bicicleta";
```

- For ou foreach para imprimir todos os elementos de uma coleção

```c#
foreach (string v in veiculos) { // não rola pois string não é o tipo da coleção
	Console.WriteLine(v);
}

foreach (KeyValuePair<int, string> v in veiculos) {
    Console.WriteLine(v.Value);	// ainda precisa indicar se quer a chave ou o valor.
}

foreach (string v in veiculos.Values) { // o mais fácil
    Console.WriteLine(v);
}
```

- Outra forma de imprimir
  - Todos os elementos estão no valores, que é do tipo ValueCollection

```c#
Dictionary <int, String>.ValueCollection valores = veiculos.Values;

foreach string v in valores {
    Console.WriteLine(v);
}
```

- Observação: às vezes usa-se Key/Value no plural, às vezes no singular. Observe o contexto: refere-se a somente um valor específico ou a todos do dicionário?

---

### Aula 56 - Coleção LinkedList = Lista duplamente encadeada

- Cada elemento é um nó da lista, que tem os links para os elementos posterior e anterior
- Vou chamar de lista2 para não confundir com List (próxima aula)
- Lembrar do `using System.Collections.Generic;`

```c#
LinkedList<tipoLista2> nomeLista2 = new LinkedList<tipoLista>();
LinkedList<string> transporte = new LinkedList<string>();
```

- **`lista2.AddFirst(valor);`**
  - Adiciona o valor no início. Ou seja, o último a ser adicionado é o primeiro a ser impresso.
- **`lista2.AddLast(valor);`**
  - Adiciona no final;

```c#
transporte.AddFirst("Carro");
transporte.AddLast("Aviao");
```

06:50 12/10/2020

- **`lista2.AddAfter(node, value), lista.AddBefore(node, value);`**

```c#
LinkedListNode<string> no;
no = transporte.FindLast("Navio"); // .FindLast(valor) renorna um nó de lista encadeada
transporte.AddAfter(no, "Charrete");
transporte.AddBefore(no, "Patinete");
```

- **`node.Next; node.Previous; node.Value`**

```c#
no = transporte.FindLast("Motocicleta").Next; // no = valor seguinte à motocicleta

Console.WriteLine(no.Value);
Console.WriteLine(no.Previous.Value); // "Motocicleta"
```

- **`lista2.Remove(value), RemoveFirst(), RemoveLast(), Clear()`**

```c#
lista2.Remove(valor); // valor específico

lista2.RemoveFirst(); // primeiro
lista2.RemoveLast(); // último

lista2.Clear(); // apaga tudo
```

- Imprimir os elementos (mais fácil que dicionário)

```c#
foreach (string v in transporte) {
	Console.WriteLine(v);
}
```

- **`lista2.Find(value)`**
  - <u>Retorna a referência se existir ou **`null`** se não existir;</u> 

```c#
if (transporte.Find("Carro") == null) {
	Console.WriteLine("Não encontrado");
} else {	
	Console.WriteLine("Elemento encontrado");
}
```

---

### Aula 57 - Coleção List (Parte 1)

- Eu chamei o LinkedList anterior de lista, mas entenda que ele é diferente de List
- Usada para substituir o array tradicinal. Mais versátil, mais fácil de trabalhar. Possui vários métodos. "Array tunado"
- Não esquecer do `using System.Collections.Generic;`

```c#
List<string>carros = new List<string>();	
```

- **`lista.Add(valor)`**
  - testar se o add funciona com LinkedList

```c#
veiculos.Add("HRV");
```

- **`lista_recebe.AddRange(lista_envia);`**

```c#
veiculos.AddRange(carros); // copia todos os elementos da lista carros para veiculos
```

- **`lista.Clear();`**
- **`lista.Contains(valor)`**; 
  - retorna true ou false

```c#
if (carros.Contains(valor)) {
```

- **`lista_envia.CopyTo(array_destino, pos_array_destino);`**
  - O destino não pode ser outra lista (pelo menos foi o que eu percebi), e sim um array.
  - CopyTo copia todos os elementos da lista para o array, a partir da posição indicada deste.

```c#
string [] carros2 = new string[10];
carros.CopyTo(carros2, 2); // pos 0 e 1 ficarão com seus valores de antes
```

- **`lista.IndexOf(valor);`**
  - retorna a posição da primeira ocorrência ou **-1** (se não encontrar)

```c#
Console.WriteLine("Está na posição " + carros.IndexOf(valor));
```

- Impressão dos itens é igual `LinkedList`

```c#
foreach (string x in carros) {
	Console.WriteLine(x);
}
```

---

### Aula 58 - List (Parte 2)

- **`lista.Insert(pos, valor);`**

```c#
carros.Insert(1, "Cruze");
```

- **`lista.LastIndexOf(valor);`**

```c#
carros.Add("HRV");
int ultimo = carros.LastIndexOf("HRV");
```

- **`lista.Remove(valor);`** e **`lista.RemoveAt(posicao);`**

```c#
carros.Remove("Argo");
carros.RemoveAt(0);
```

- **`lista.Reverse();`**

```
carros.Reverse(); // simplesmente inverte
```

- **`lista.Sort();`**
  - Ordem alfabética ou numérica

```c#
carros.Sort();
```

- **`lista.Count;`** // se não tiver elementos, o resultado é zero

```c#
int tamanho = carros.Count // propriedade. É tipo um length
```

- **`lista.Capacity;`**
  - Quantos elementos cabem na lista. Dá para alterar
  - É uma propriedade também
  - Diminuir a capacidade para um número menor do que Count dá erro

```c#
int cap = carros.Capacity;
carros.Capacity = 15;
```

---

### Aula 59 - Coleção Queue (Fila)

- Última aula no modo console, na próxima teremos VS 2019 com janela gráfica :tada:
- Particularidade: o primeiro a ser adicionado é o primeiro a sair. First In, First Out.
- Só dá para visualizar o elemento que está na frente (em primeiro), não é possível manipular os demais

```c#
Queue<string>veiculos = new Queue<string>();
```

- Dá para inicializar passando uma coleção para o construtor (tem que testar se isso funciona para as outras coleções)

```c#
string[] vs = {"Carro", "Moto", "Navio", "Aviao"};
Queue<string> veiculos = new Queue<string>(vs);
```

- **`fila.Enqueue(valor);`** 	// adicionar elementos no **final da fila**

```c#
veiculos.Enqueue("Jegue");
```

- **`fila.Count;`**  // quantos espaços estão preenchidos

- **`fila.Contains(valor);`**  // retorna true ou false

  ```c#
  if (comidas.Contains("Bolo")) {
  ```

- **`fila.Clear();`**

- **`fila.Dequeue();`**  // retornar e remover elementos do **início da fila**

  - Retorna o primeiro elemento da fila e o remove dela

```c#
Console.WriteLine("Primeiro veículo: " + veiculos.Dequeue()); // 
Console.WriteLine(veiculos.Count); // terá um elemento a menos
```

- **`fila.Peek()`**;  // apenas retornar o **primeiro**
  - Retorna o primeiro elemento mas **não remove**.

```c#
Console.WriteLine("Primeiro: " + veiculos.Peek());
```
- Imprimir todos os elementos
  - pode fazer com foreach + peek/dequeue ou um foreach normal (abaixo)
```c#
foreach (string z in veiculos) {
	Console.WriteLine(z);
}
```

- Mas atenção: Queue não trabalha com indexadores. <u>Não existe</u>: `int c = veiculos[3]`
  - Só consegue acessar o primeiro elemento da fila.

```c#
while (veiculos.Count > 0) {
	Console.WriteLine(veiculos.Dequeue);
}
Console.WriteLine(veiculos.Count); // 0
```

- Ex. de uso: um jogo de cartas em que se retira cartas de um monte.

---

### Até mais ✔

- **Termina aqui o modo console**
- Estes foram os pontos principais da linguagem C#. Não é tudo que o que a linguagem faz, faltou muita coisa!

<!-- Próximo caderno: [formulários (janelas) Windows](Caderno C# [parte 2].md).-->

12/10/2020, segunda



