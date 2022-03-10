import { Component } from "react";
// import axios from "axios";
import './LoginCandidato.css'
import LogoIJ from "../Assets/LogoIJ.png";

export default class LoginCandidato extends Component {

    constructor(props) {
        super(props);
        this.state = {
            email: '',
            senha: '',
        }
    }

    // efetuaLogin = () => {
    //     event.preventDefault();

    //     axios.post('//passar localHost', {
    //         email : this.state.email,
    //         senha : this.state.senha
    //     })

    //     .then(Response => {
    //         if (Response.status === 200) {

    //             console.log("login realizado")

    //         }
    //     })
    // }



    render() {
        return (

            <div >
                <sectoin class="conteudoLogin">

                    <div >
                        <img class="" src={LogoIJ} />
                    </div>

                    <div>
                        <h1 class="fraseInner">Acesse sua conta Inner</h1>
                    </div>

                    <form onSubmit={this.efetuaLogin}>
                        <p class="email">E-mail</p>
                        <input
                            type="text"
                            name="email"
                            value={this.state.email}
                            onChange={this.atualizaStateCampo}
                        />

                        <p class="senha">Senha</p>
                        <input
                            type="password"
                            name="senha"
                            value={this.state.senha}
                            onChange={this.atualizaStateCampo}
                        />

                    </form>

                    <p class="esqueciSenha">Esqueci minha senha</p>

                    
                        <button class="entrar" type="submit" > Entrar </button>
                    

                    <p class="naoConta">Ainda não tem conta? <span class="criaConta">Criar conta</span>  </p>

                </sectoin>
            </div>

        )
    }
}



