### Aula 60 - Janelas no padrão Windows

12/10/2020, segunda

- Baixar: Visual Studio Community. Na página de configuração, deixar marcado "Desenvolvimento para Desktop com .NET"
- Criar projeto: Aplicativo do Windows Forms
- Formulário = janela
- Lado direito
  - acima: gerenciador de soluções;
  - abaixo: propriedades do forms selecionado; 
    - raio: eventos (mouse, clique, tecla, ações, acontecimentos)

- Design -> name - colocar um nome que evidencie o tipo e facilite a identificação instantânea.

  

![image-20201012182313573](C:\Users\Otávio estudos\AppData\Roaming\Typora\typora-user-images\image-20201012182313573.png)

tudo é muito bonito

---

### Aula 61 - Formulário, manipulação de componentes, evento de clique

- Ver o código: `F7`, ver designer `shift`+ `f7`
-  Bibliotecas importadas cinza: ainda não estão sendo utilizadas.
- Codificar depois de definir os names em propriedades -> design

```c#
public partial class Principal : Form // name do forms (não é text) herda de Form
    {
        public Principal() // construtor
        {
    ...
```

```c#
 private void bt_texto_Click(object sender, EventArgs e) // método ao clicar no botão
        {
            /*String txt;
            txt = tb_texto.Text;
            lb_texto.Text = txt;*/
            lb_texto.Text = tb_texto.Text; // escrever o que está na caixa no label
        }
```

### Aula 62 - Componente Textbox

- Marcar como multiline nas propriedades rápidas (triângulo ao lado do objeto): permite dimensionar para a caixa de texto em todas as direções (não vai ficar apenas uma barra horizontal)
  - Inclusive deixa o usuário digitar mais de uma linha

![image-20201014105042475](C:\Users\Otávio estudos\AppData\Roaming\Typora\typora-user-images\image-20201014105042475.png)

- Com o forms selecionado:
  - [Font] FormerBorderStyle: FixedDialog (não dá para redimensionar a janela)
  - [Size] StartPosition: CenterScreen
  - [Icon] MaximizeBox: False; MinimizeBox: True;

```c#
namespace Aula062_Textbox
{
    public partial class f_Principal : Form
    {
        public f_Principal()
        {
            InitializeComponent();
        }

        private void bt_Inserir_Click(object sender, EventArgs e)
        {
            if (tb_inserir.Text == "")
            {
                MessageBox.Show("Digite um veículo!");
                tb_inserir.Focus(); // posiciona o cursor na caixa
                return;
            }
            tb_2.Text += tb_inserir.Text + ", ";
            // tb_inserir.Text = "";
            tb_inserir.Clear(); // não é .Text.Clear()
            tb_inserir.Focus();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_2.Clear();
            tb_inserir.Clear();
            tb_inserir.Focus();
        }

       
    }
}

```

- Desafio aula 62: deixar o que for inserido em uma coleção list

---

### Aula 63 - Chamar um novo formulário

- Como abrir uma nova janela

```c#
 private void bt_mostrar_Click(object sender, EventArgs e)
        {
            f_Secundario veiculos = new f_Secundario(tb_veiculos.Text); // chamando outro formulário
            // veiculos.Show(); permite clicar na janela debaixo
            veiculos.ShowDialog(); // não deixa, nem se minimizar
        }
```

- No construtor do outro formulário

```c#
public f_Secundario(String v)
        {
            InitializeComponent();
            tb_veiculos.Text = v;
        }
```

---

### Aula 64 - Enviar dados de um formulário para outro

- Atribuir um valor a um form pai a partir do form filho.
- Aula passada foi o inverso: passou do pai para o filho por um construtor

```c#
 public partial class f_Secundario : Form
    {
        f_Principal fp; // criado para poder usar f fora do construtor

        public f_Secundario(String v, f_Principal f)
        {
            InitializeComponent();

            tb_veiculos.Text = v;

            fp = f;

            f.num = 10; // importante: variável public. fp é o objeto da classe f_Principal?

        }
```

```c#
private void f_Secundario_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_veiculos.Text = this.tb_veiculos.Text;  
    
    // tem que ir em design -> modificador -> public (por padrão é private)
        }
```

---

### Aula 65 - Como criar um menu

parei em 3:40

- Componente MenuStrip