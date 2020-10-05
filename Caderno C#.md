# Bem vindo ao meu caderno

- **As coisas ficam mais legais a partir da *aula 9***

- **Não está muito didático, então deixe isso aqui para revisão**

- **Veja os códigos das aulas na pasta [CFB](CFB/)**

  

  

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


```
Array.IndexOf(vetor, valor);
```
- posição da primeira ocorrência. -1 se não existir. somente para vetor unidimensional.


```
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
- Vários construtores de mesmo nome, mas o conjunto de parâmetros é diferente.
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

### Aula 31 - Classes static

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
- Em métodos abstratos, não se implementa o comportamento, cria-se apenas o protótipo que vai servir como referência para as classes herdeiras. Não há conteúdo.
  - Obriga que as classes derivadas implementem os métodos (conteúdo)
- Métodos não abstratos: contém a implementação, que é obrigatória.
- Esqueceu? [Veja aqui](#Tipos Classe)

> 'Livro.aumentarPeso(int)' não pode declarar um corpo porque está marcado como abstract
>
> 'Revista' não implementa o membro abstrato herdado 'Livro.aumentarPeso(int)'