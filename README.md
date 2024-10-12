<h1 align="center">Simulator Télos Nível 5 - .NET com C# 🚀</h1>


Este é um sistema simples de gerenciamento de tarefas estilo Kanban, que simula a organização de atividades dentro de uma equipe de desenvolvimento. O sistema permite adicionar tarefas, movê-las entre listas de status ("A fazer", "Em progresso" e "Concluído") e visualizar o estado atual das tarefas em cada uma dessas listas. A aplicação é interativa e executada via console.

## Funcionalidades

### 1. Menu Principal
Ao iniciar o sistema, o usuário é apresentado com um menu contendo as seguintes opções:
- **1 - Adicionar nova tarefa:** Permite ao usuário criar uma nova tarefa e adicioná-la à lista "A Fazer".
- **2 - Exibir tarefas:** Exibe as tarefas organizadas nas listas "A Fazer", "Em Progresso" e "Concluído".
- **3 - Mover tarefa:** Permite ao usuário mover uma tarefa entre as listas.
  - De "A Fazer" para "Em Progresso".
  - De "Em Progresso" para "Concluído".
  - Retornar uma tarefa para uma lista anterior, se necessário.
- **4 - Sair:** Encerra a aplicação.

### 2. Adicionar Nova Tarefa
- O sistema solicitará ao usuário o nome da tarefa.
- A tarefa será adicionada à lista **"A Fazer"** automaticamente.

### 3. Exibir Tarefas
- O sistema exibirá todas as tarefas divididas nas seguintes listas:
  - **A Fazer:** Tarefas ainda não iniciadas.
  - **Em Progresso:** Tarefas que estão sendo trabalhadas.
  - **Concluído:** Tarefas que foram finalizadas.

### 4. Mover Tarefa
- O usuário poderá mover uma tarefa entre as listas com base no progresso do trabalho.
  - Mover de **"A Fazer"** para **"Em Progresso"**.
  - Mover de **"Em Progresso"** para **"Concluído"**.
  - O usuário também pode retornar uma tarefa, se necessário, para uma lista anterior.

### 5. Sair
- Ao escolher a opção de sair, o sistema será encerrado.

## Requisitos
Para rodar este sistema, é necessário um ambiente de desenvolvimento com suporte a execução de programas em C#.

### Como Executar

1. **Clone o repositório** ou baixe os arquivos do projeto.
   
2. Abra o projeto no **Visual Studio** ou outro editor compatível.

3. Compile e execute o projeto.

4. Interaja com o sistema através do menu apresentado no console.

## Tecnologias Utilizadas
<div>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#" style="border-radius:4px"/>
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" style="border-radius:4px"/>
</div>
