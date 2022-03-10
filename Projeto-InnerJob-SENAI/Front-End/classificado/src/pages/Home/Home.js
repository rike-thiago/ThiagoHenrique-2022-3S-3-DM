import { Component } from 'react';

import './Home.css';
import LogoHeader from '../Assets/LogoHeader.png';
import Moca from '../Assets/Moca.png';



export default class Home extends Component {

  render() {
    return (
      <div class="pageHome">
        <header class="header">

          <section class="conteudoHeader">

            <div>
              <img class="imgLogo" src={LogoHeader} alt="InnerJob"  />
            </div>

              <button class = "botaoLogin">
                Login / Cadastro
              </button>

          </section>
        </header>

        <main>

          <section class="conteudoMain">

            <div class="conteudoTexto">
              <div class="geralFrase">
                <h1 class="fraseImpacto1">Se junte ao projeto que </h1>
                <h1 class="color1">conecta jovens talentos</h1>
                <h1 class="fraseImpacto2">com as melhores</h1>
                <h1 class="color2">empresas do mercado</h1>
              </div>
              <p class="frasePensativa"> Se você cansou de ficar horas e horas procurando vagas de emprego pela internet, clique no botão abaixo e se junte a nós</p>
              <button class="botaoComeçar" >
                Começar
              </button>
            </div>

            <div>
            <img class="imgMain" src={Moca} alt="Moça" />
            </div>


          </section>

        </main>
      </div>
    )
  }
}