# InvenTrack 

Este projeto é uma aplicação em **C# (.NET Framework 4.8.1)** voltada para o gerenciamento de inventário em **Windows Forms**.  
A aplicação oferece login, registro e controle de itens.

---

## 📌 Visão Geral

O InvenTrack foi desenvolvido para facilitar o controle e registro de itens em ambientes de estoque.  

---

## ⚙️ Tecnologias Utilizadas

- [.NET Framework 4.8.1](https://learn.microsoft.com/en-us/dotnet/framework/)
- Windows Forms (WinForms)
- `System.Drawing` para renderização visual
- `System.Windows.Forms` para interface gráfica
- Componentes personalizados em C# (`RoundButton`, `RoundedTextBox`, etc.)

---

## 🚀 Como Executar

### 1. Requisitos

- Visual Studio 2019 ou superior
- .NET Framework 4.8.1 instalado  
- Sistema operacional Windows

### 2. Clonando o projeto

```bash
git clone https://github.com/velocirary/InvenTrack.git
cd InvenTrack
```

### 3. Compilação

Abra o arquivo .sln no Visual Studio e pressione F5 para compilar e executar a aplicação.


## 🧠 Lógica do Projeto

A aplicação é dividida em componentes visuais e formulários funcionais.

🧩 Componentes
- RoundButton: botão com bordas arredondadas e estilo customizado
- RoundedTextBox: campo de texto com visual moderno
- RoundedComboBox: combo box estilizado
- TransparentLabel: rótulo com fundo transparente para sobreposição visual

🗃️ Formulários
- InvenTrackLogin: tela de login
- InvenTrackRegister: tela de registro de novo usuário
- InvenTrackHome: tela principal de controle de inventário

## 🗂 Estrutura

```
InvenTrack/
├── Components/
│   ├── RoundButton.cs
│   ├── RoundedTextBox.cs
│   ├── RoundedComboBox.cs
│   └── TransparentLabel.cs
├── Forms/
│   ├── InvenTrackLogin.cs
│   ├── InvenTrackRegister.cs
│   └── InvenTrackHome.cs
├── Properties/
│   ├── Resources.resx
│   ├── Settings.settings
│   └── AssemblyInfo.cs
├── Resources/
│   ├── BackGroundHome.png
│   └── RoundButton.png
├── Program.cs
└── InvenTrack.csproj
```

---

## ✅ Funcionalidades

- 🔐 Autenticação de usuários via formulário de login
- 📝 Registro de novos usuários
- 📦 Interface para controle de inventário
- 🧭 Navegação fluida entre tela
