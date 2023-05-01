# Passo a passo do uso do git e GitHub segundo o curso da DIO.

### Configurar o Git:

Usuário: **git config — global user.name** _“Carol Rocha”_

E-mail: **git config — global user.email** _email do github_

Editor: **git config — global core.editor vim**

### Criando um repositório:

1- Abrir gitbash no /C

2- **mkdir workspace** — cria pasta workspace

3- **cd workspace** — vai para a pasta workspace

4- **mkdir _nomedapasta_** — cria a pasta desejada

5- **cd _nomedapasta_** — vai para a pasta desejada

6- **git init** — inicia um repositório git na pasta

### Criar o arquivo desejado.

**git add * ** adiciona todos os arquivos

**git commit -m** _“explicar o que foi feito nesse commit”_

**git remote add origin** _colar https ou ssd do repositório remoto_ para adicionar o repositório local ao GitHub

**git push origin (_alias do github por convenção_) master _(nome do branch)_** envia o repositório local para o repositório remoto já linkado no passo anterior

### Comandos úteis:

- **ls** lista os arquivos na pasta
- **ls --a** lista inclusive os arquivos ocultos
- **ctrl + l** limpa a área de trabalho
- **cd ..** sobe um nível
- **git status** mostra o status da working tree
- **mv arquivo ./_pasta_** move o arquivo para a pasta desejada
- **git remote -v** lista os repositórios cadastrados
