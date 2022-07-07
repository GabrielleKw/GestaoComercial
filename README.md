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

Explicação botão 'Salva' e 'Adicionar Itens'

![image](https://user-images.githubusercontent.com/76081229/177784178-5c480fff-cef7-44a8-8fff-e5837a2f3f1d.png)

Na opção/botão 'Salva' você salva a venda e adicionar os itens vendidos em outra hora... Para isso basta abir a tela de Pesquisar Vendas (Você faz isso clicando no botão Pesquisar ) e dar dois clique na linha com a venda deseja. Será direcionado a tela de cadastro e clique em 'Adicionar Itens'.

 ![image](https://user-images.githubusercontent.com/76081229/177784650-0fcf53f7-fe10-4f51-be9b-3eb653790c5c.png)
 ![image](https://user-images.githubusercontent.com/76081229/177784780-d6db0dfb-4509-45ba-8662-16219498c3c8.png)

Na opção 'Adicionar Itens' é para quem já cadastro a venda e já vai adicionar os itens, assim que clicar no botão ' adicionar itens ' caso a venda não exista no banco de dados, será criada. Caso exista igual o caso acima será apenas atualizada. 

Tela de cadastro do itens/produtos 

![image](https://user-images.githubusercontent.com/76081229/177785205-75a44f14-31d7-475b-9e94-b987a5d2da36.png)

<h1> Obs </h1>
Todas as telas possuem a tecla Tab configurada na ordem correta para melhorar a exeperiencia do usuário. 

<h1> Me conheça </h1>

<p align="left">
<a href="https://www.linkedin.com/in/gabriellekwsiqueira/" target="blank"><img align="center" src="https://th.bing.com/th/id/OIP.M2yKY291zt8FiB681yqoqwAAAA?pid=ImgDet&rs=1" alt="gabrielleLink" height="30" width="40" /></a>
<a href="https://www.instagram.com/kw_gabrielle/" target="blank"><img align="center" src="[https://th.bing.com/th/id/R.ad1fdf133f291aa1594ecf23efe0f924?rik=0xg5BgirmSq1%2fQ&pid=ImgRaw&r=0](https://th.bing.com/th/id/R.99d34c78d03140bd605afd14dca01ed6?rik=nmkpUJtDFIXb1A&pid=ImgRaw&r=0)" alt="gabekw.insta" height="30" width="40" /></a>
</p>
