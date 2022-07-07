<h3 align="center"> 
# GestaoComercial
</h3> 

<p align="justify" >
  
[Descontinuado] Sistema de gestão para empresas comerciais ,desenvolvido em Csharp. Com utilização de Windows Forms e banco PostgreSQL. 
</p>

<h1> Tela Login </h1> 
Iremos ver abaixo nas imagem a tela de login e tela caso inserir senha ou nome de usuário incorretos.
  
   ![image](https://user-images.githubusercontent.com/76081229/177779978-4b5b3b35-9bfe-4b8b-9261-6f1e1a680eba.png)
   ![image](https://user-images.githubusercontent.com/76081229/177780052-7641fa71-33ff-4e58-8238-c8b15de64f25.png)

<h1> Tela Inicial do Sistema </h1> 
Nessa tela teremos o menu do sistema, irei colocar cada um em imagens abaixo. 


  ![image](https://user-images.githubusercontent.com/76081229/177780243-f7056f2d-0e5b-420d-906c-5074c96dbee0.png)


![image](https://user-images.githubusercontent.com/76081229/177780275-3223fbf4-24fe-41f1-87ee-7de52b03d65c.png)
![image](https://user-images.githubusercontent.com/76081229/177780306-15291fd1-37ef-48b4-94c8-2a14366e7f68.png)
![image](https://user-images.githubusercontent.com/76081229/177780381-247a0a03-c69f-4645-82bb-ddb1f24326eb.png)
![image](https://user-images.githubusercontent.com/76081229/177780408-76a9bac8-4675-4644-8e2e-e34482cbdbfa.png)

<h1> Tela Cadastro de um Cliente/Terceiro </h1> 

  ![image](https://user-images.githubusercontent.com/76081229/177781474-1f678f5e-48c9-4006-9d01-a3fb2ee6cd41.png)

Após clicar em 'Salvar' 

![image](https://user-images.githubusercontent.com/76081229/177781657-ded81469-4470-4d6a-a3ed-10cd3c764f39.png)

Opção/botão 'Pesquisar'

![image](https://user-images.githubusercontent.com/76081229/177781780-57f0187b-4f87-458c-864c-f712ad2b98a0.png)

Opção/botão 'Atualizar'

![image](https://user-images.githubusercontent.com/76081229/177781896-3b8b9f85-c044-42e0-936c-9068ac6c0269.png)

Para altera ou excluir um cliente, basta acessar a tela de pesquisa e das dois clique na linha e que deseja alterar ou excluir. Pois ao clicar os dados serão carrgados na tela Cadastras Cliente/Terceiro e você pode realizar as ações 

![image](https://user-images.githubusercontent.com/76081229/177782222-708bf218-27e9-4260-9950-d859a64526f9.png)

Veja que após exclução o nosso relatório de cadastrados fica diferente 

![image](https://user-images.githubusercontent.com/76081229/177782394-c0c390f2-ea01-404a-a6be-ed555cd1f7d0.png)

As demais telas 'Cadastro Produto', 'Cadastro Funcionário' seguem o mesmo padrão.

<h1> Tela Cadastro de uma venda </h1> 

Em meu banco de dados possuo duas tabelas para realização de uma venda. TabVenda que contém as informações da venda, e TabVenda_Itens que contém nesse caso os produtos que foram vendios nessa venda. 
A tela abaixo é nossa tela de Venda relacionada com a TabVenda. 

![image](https://user-images.githubusercontent.com/76081229/177783096-7fef3f0c-3d5d-4434-86a0-8454f5952f35.png)

Explicação Botão 'Pesquisar Cliente' 

Permite que o usuário pesquise todos os cliente na Tela Pesquisar Cliente/Terceiro, pois pra TabVenda preciso do ID do cliente, assim o usuário pode pesquisar pelo nome sem necessidade de inserir manualmente. Carrego o nome do cliente na tela de Venda apenas para ficar visualmente facil entender para quem é feito a venda. No banco utilizo apenas o ID. 

![image](https://user-images.githubusercontent.com/76081229/177783803-9b22d0f6-9669-4b6b-90a3-f29facfdfb93.png)

Seguimos o mesmo esquema de dois clique na tela pesquisa, ira carrega os dados na tela Cadastro Venda

![image](https://user-images.githubusercontent.com/76081229/177784023-ce80ab40-00db-470b-a5ab-1df783bd8f6b.png)

