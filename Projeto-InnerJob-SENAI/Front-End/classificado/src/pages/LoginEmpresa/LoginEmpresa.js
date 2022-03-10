import { Component } from "react";
import './LoginEmpresa.css'
import LogoIJ from "../Assets/LogoIJ.png";

export default class LoginCandidato extends Component {

    
 
    

    render() {
        return (

            <div>
               <sectoin class="conteudoLogin">

                   <div >
                       <img class="" src={LogoIJ}/>                      
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

                   <p class="esqueciSenha">Esqueci minha senha</p>

                   <div>
                       <button class="entrar"> Entrar </button>
                   </div>

                   <p class="naoConta">Ainda não tem conta? <span class="criaConta">Criar conta</span>  </p>

               </sectoin>
            </div>

        )
    }
}