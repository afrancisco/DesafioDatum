#language Pt-br
Feature: RealizarPedido
	Como um cliente cadastrado no automationpractice.com
	Eu quero fazer a compra de ao menos dois produtos
	Para que eu possa me vestir melhor

#Scenario Outline: Usuário cadastrado no sistema
@mytag
Scenario: Adicionar ao carrinho
	Given que eu esteja logado na aplicação
	When eu adicionar um item ao carrinho
	Then é exibida a confirmação do item no carrinho de compras
	
