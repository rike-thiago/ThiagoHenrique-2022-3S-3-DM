import { Component } from "react";
import './CadastroEmpresa.css'
import LogoIJ from "../Assets/LogoIJ.png";

export default class LoginCandidato extends Component {


    render() {
        return (

            <div class="conteudoLogin">
                <sectoin>

                    <div >
                        <img class="imgLogo" src={LogoIJ} />
                    </div>

                    <div>
                        <h1 class="fraseInner">Acesse sua conta Inner</h1>
                    </div>

                    <div>
                        <p class="email">E-mail</p>
                        <input></input>
                    </div>

                    <div>
                        <p class="senha">Senha</p>
                        <input></input>
                    </div>

                    <div>
                        <p class="confirmeSenha">Confirme a senha</p>
                        <input></input>
                    </div>

                    <div>
                        <button class="entrar"> Entrar </button>
                    </div>

                    <div class="seguraTexto">
                        <p class=" fraseTermos">Ao clicar em começar, você indica que leu e concorda com nossos <span class="termoUso">Termos de Uso</span> e nossa <span class="politicaPri">Política de Privacidade</span> </p>
                    </div>

                    <div class="">
                        <p class="naoConta">Ainda não tem conta? <span class="criaConta">Criar conta</span>  </p>
                    </div>



                </sectoin>
            </div>

        )
    }
}