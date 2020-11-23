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
- 