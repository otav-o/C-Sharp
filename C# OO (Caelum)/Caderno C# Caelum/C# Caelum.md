## História e conceitos

- Década de 90: Sun Microsystems processou a Microsoft por violar o licenciamento do Java, impedindo-a de usar o J++, uma variação da linguagem exclusiva para ambiente Microsoft
- Projeto COOL (C-Like Object Oriented Language) - design baseado em outras linguagens como Java, C, C++, Smalltalk, Delphi e VB
  - Lançado em 2002 como linguagem C# e ambiente .NET
- O C# utiliza o conceito de máquina virtual. Entre o sistema operacional e a aplicação existe uma camada extra responsável por "traduzir" o que sua aplicação deseja fazer para as respectivas chamadas do sistema operacional onde ela está rodando no momento
- **A aplicação roda na Common Language Runtime (CLR), ambiente de execução (máquina virtual) para todas as linguagens da plataforma .NET**
  - Isola a aplicação do SO, evitando que ela afete outras máquinas virtuais.
  - Linguagem intermediária: *Common Intermediate Language* (CIL), que é o código compilado

> Linguagem intermediária CIL será executada pela CLR - máquina virtual da plataforma .NET que comporta várias linguagens além do C#

- Common Language Infrastructure
  - CLI = CLR (máquina virtual) + CIL (linguagem intermediária)
- A CLR, por sua vez, precisa emitir o código de máquina correto para o ambiente em que o programa está sendo executado
  - Converte automaticamente o código CLI para código de máquina, por um compilador *Just in Time* (JIT) da CLR
  - Permite que o desempenho seja o mesmo de um compilador sem código intermediário
- O código CIL é colocado pelo compilador em um arquivo executável (arquivo com extensão .exe) dentro da pasta do projeto. Esse arquivo que é resultado da compilação do programa é chamado de Assembly dentro da linguagem C#

![image-20201118103953303](image-20201118103953303.png)

---

### Conversão perigosa

```c#
decimal numeroGrande = 10;
double numeroPequeno = 25;

numeroPequeno = (double) numeroGrande;
Console.WriteLine(numeroGrande + "  " + numeroPequeno);
```

```c#
short valorPequeno = 100;
long valorGrande = 25;

valorGrande = valorPequeno; // não precisa do cast pois long > short

Console.WriteLine(valorGrande);
```

```c#
double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado: " + piQuebrado);
```

---

### Classes e Objetos

- Programação procedural (sem uso de objetos): sem garantia de validação de dados e uso de diversas variáveis que ficam espalhadas no código (imagine o registro de contas de clientes de um banco)
- O código da classe, por convenção, deve ficar dentro de um arquivo com o mesmo nome da classe.

```c#
class Conta {
	public int numero;
    public string titular;
    public double saldo;
}
```

- Variáveis que descrevem uma classe: **atributos**
- Classe funciona como uma receita/molde que define o formato das instâncias = objetos
- Ao usar o `new`, o C# cria uma instância, ou seja, aloca memória suficiente para guardar informações do objeto
  - Inclusive retorna uma referência que aponta para o objeto em memória

```c#
Conta c = new Conta();
```

- Definir os atributos armazenados no objeto c

```c#
c.numero = 1;
c.titular = "Victor";
c.saldo = 100;
```

![image-20201119082706947](image-20201119082706947.png)

- quando utilizamos um objeto para guardar informações, todos os atributos ficam agrupados dentro de um único objeto na memória, e não espalhados dentro de diversas variáveis diferentes.

#### Métodos para objetos

- Não precisa definir um método estático e passar a referência do objeto por parâmetro

```c#
public void saca(double valor)
{
    if (valor <= saldo)
    {
        saldo -= valor;
    }
}
```

- Basta chamar o método direto do objeto

```c#
c1.saca(15);
```

#### Valores padrão dos atributos

- Quando instanciamos uma classe todos os seus atributos são inicializados para valores padrão. 
  - Ao contrário de variáveis dentro de métodos, que precisam ser inicializadas.
- Valores numéricos são inicializados para zero, o bool é inicializado para false e atributos que guardam referências são inicializados para a referência vazia (valor null do C#).

| Tipo                           | Inicialização  |
| ------------------------------ | -------------- |
| bool                           | false          |
| int, float, double, long, etc. | 0              |
| objetos, vetores               | null           |
| string                         | "" (confirmar) |
| char                           | '' (confirmar) |

```c#
public void transfere (Conta destino, double valor)
        {
            if (this.saca(valor))
            {
                destino.saldo += valor;
            }
        }
```

- Convenção de nomes
  - **PascalCasing**: classes e métodos de classe
  - Argumentos de métodos: **camelCasing**

```c#
Conta mauricio = new Conta(); // mauricio aponta a um objeto
mauricio.Saldo = 2000;

Conta copia = mauricio; // copia passa a apontar para esse objeto (não cria outro)
copia.Saldo = 3000;

MessageBox.Show("Mauricio = " + mauricio.Saldo); // são o mesmo objeto, os dois imprimem 3000
MessageBox.Show("Copia = " + copia.Saldo); // duas variáveis, um objeto
```

- Inclusive, objetos são sempre diferentes entre si, mesmo que tenham os mesmos valores de propriedade. Usou o `new`, o espaço na memória é diferente

---

### Get e Set (encapsulamento)

- **Auto-implemented properties** - a partir do C# 3.0
  - ao utilizarmos as auto-implemented properties, **só podemos acessar o valor do atributo declarado através da propriedade** (mesmo que seja de dentro da classe).

```c#
class Conta
{
	public int Numero { get; set; }
}
```

---

### Construtor

public [nomeClasse] (parâmetros) {

}

---

### Atalhos Visual Studio

`ctrl + .` - atalho para a caixa de erro da linha selecionada

`prop + tab + tab` - cria propriedade facilmente. Tab para navegar entre tipo de dado e nome

`ctor + tab + tab` - cria um construtor para a classe

Instanciar um objeto de classe inexistente dispara um atalho para o VS criar automaticamente. Outros erros também são auxiliados pela IDE.

```c#
textoTitular.Text = c1.Titular.Nome;
textoNumero.Text = Convert.ToString(c1.Numero);
```

`mbox + tab + tab` - cria um MessageBox.Show(" ");

`ctrl + R (2x)` - renomear uma variável ou método

`ctrl + :` - autocomplete

Groupbox: organizar itens do formulário. Não vi a aplicação dele no código

Label: texto na tela

---

- Variáveis dentro de métodos podem ser declaradas como var em C# que o seu tipo é inferido automaticamente. Para o compilador acertar qual o tipo da variável ela deve ser inicializada no mesmo instante que é declarada e não pode ser atribuído o valor null.

```c#
var conta;
conta = new Conta();
conta.Deposita(300);

var tamanho = 5;
tamanho = tamanho / 2.0;
MessageBox.Show(tamanho);
```

---

### Herança

- Maneira de reaproveitar código sem aumentar sua complexidade
- Subclasse = classe filha; classe base = classe pai

```c#
public class ContaPoupanca : Conta { }

ContaPoupanca c = new ContaPoupanca();
c.Deposita(100.0);
```

#### Métodos virtuais e override

- Basta reescrever o comportamento na classe filha, usando a palavra override e mudando a classe pai para indicar que o método pode ser sobrescrito (virtual)

```c#
// Arquivo Conta.cs
public class Conta
{
    public virtual void Saca(double valor)
    {
    	this.Saldo -= valor;
    }
    	// Resto do código da classe
}
// Arquivo ContaPoupanca.cs
public class ContaPoupanca : Conta
{
    public override void Saca(double valor)
    {
    	this.Saldo -= (valor + 0.10);
    }
}
// Código do formulário da aplicação
ContaPoupanca c = new ContaPoupanca();
// chama o comportamento escrito no pai
// O Saldo termina em 100.0 depois dessa linha
c.Deposita(100.0);
// chama o comportamento escrito na ContaPoupanca
// O Saldo termina com o valor 49.90
c.Saca(50);
```

- Atributos privados só são visíveis para a classe que os declarou. Os filhos não enxergam.
- Atributos/métodos marcados como `protected` são visíveis apenas para a própria classe e para as classes filhas:

#### Base

- É possível reutilizar o comportamento do método da classe pai, usando a palavra `base`

```c#
public class ContaPoupanca : Conta
{
	public override void Saca(double valor)
	{
		base.Saca(valor + 0.10);
	}
}
```

---

### Polimorfismo

- Imagine um método que soma os saldos de todas as contas do banco

```c#
public class TotalizadorDeContas 
{
    public double ValorTotal { get; private set; }
    public void Soma (Conta conta) 
    {
        ValorTotal += conta.Saldo;
    }
}
```

- O parâmetro passado deve ser do tipo Conta e, como ContaPoupança é uma Conta (herdeira desta), ela pode ser passada normalmente.
  - Atenção: o código só vai compilar se os métodos e propriedades utilizados no ValorTotal pertencerem à classe pai.
- Polimorfismo: capacidade de uma variável referenciar seu próprio tipo ou filhos desse tipo.
  - Certeza de que a classe TotalizadorDeContas funcionará para todo novo tipo de Conta que aparecer.
- Da mesma forma:

```c#
private Conta conta; // o tipo é Contas
//
this.conta = new ContaPoupanca();
```

#### Herança do construtor

- Por padrão os construtores não são herdados

```c#
public class ContaPoupanca : Conta
{
	public ContaPoupanca(int numero) : base (numero) { }
}
```

---

### Arrays

```c#
Conta[] contas = new Conta[5];
contas[0] = new Conta();

contas[1] = new ContaPoupanca(); // polimorfismo





```

---

### ComboBox

- É uma caixa de seleção
- Inserir elementos nela:

```c#
comboContas.Items.Add(contas[0].Titular.Nome);
comboContas.Items.Add("teste");
foreach (Conta conta in contas)
{
	comboContas.Items.Add(conta.Titular.Nome);
}
// método Add() da propriedade Items
```

- Recuperar o índice do elemento selecionado no ComboBox:

```c#
private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
        }
```

---

```c#
namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta = new Conta();
            conta.Numero = 1;

            Cliente cliente = new Cliente("Victor");

            conta.Titular = cliente;
            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);

        }
        private void deposita_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(conta.Saldo);

            MessageBox.Show("Depósito concluído");


        }

        private void textoValor_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            double valorSaque = Convert.ToDouble(textoValor.Text);
            conta.Saca(valorSaque);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);

            MessageBox.Show("Sucesso no saque");
        }
```

- Obs.: ainda não sei muito bem (preciso de mais exercícios!) como relacionar dois formulários pelo construtor (ou pelo outro jeito que foi feito)

- Obs.2: criar um botão que abre um formulário

  - ```c#
     private void botaoNovaConta_Click(object sender, EventArgs e)
            {
                // instanciar um (objeto) novo formulário
                FormCadastroConta formCadastro = new FormCadastroConta(this);
    
                // abrir a nova janela
                formCadastro.ShowDialog();
            }
    ```

    

---

### Classes abstratas

- Classe abstrata: classe de referência/base para outras classes que vão herdar dela.
  - Não dá para instanciar objetos!
- Conta pode ser classe abstrata para ContaPoupanca e ContaCorrente. Não faz sentido instanciar objetos dela
  - É um molde para as classes herdeiras
- **Método abstract**
  - Obriga as classes herdeiras a implementar o método

```
public abstract void Saca(double valor); // o método está incompleto
```



