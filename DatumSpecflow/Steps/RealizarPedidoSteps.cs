using System;
using TechTalk.SpecFlow;

namespace DatumSpecflow.Steps
{
    [Binding]
    public class RealizarPedidoSteps
    {
        [Given(@"que eu esteja logado na aplicação")]
        public void GivenQueEuEstejaLogadoNaAplicacao()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"eu adicionar um item ao carrinho")]
        public void WhenEuAdicionarUmItemAoCarrinho()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"é exibida a confirmação do item no carrinho de compras")]
        public void ThenEExibidaAConfirmacaoDoItemNoCarrinhoDeCompras()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
