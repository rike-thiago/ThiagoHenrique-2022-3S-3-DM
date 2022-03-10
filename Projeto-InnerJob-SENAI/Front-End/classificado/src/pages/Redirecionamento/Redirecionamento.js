import { Component } from "react";
import './Redirecionamento.css';
import imgEmprego from '../Assets/iconeCandidato.png'
import imgEmpresa from '../Assets/iconeEmpresa.png'



export default class Redirecionamento extends Component {

    render() {
        return (
            

            <section class="conteudoMain">

                <a class="fisica">
                    <div class="bloquinho1">
                            <img class="imgEmprego" src={imgEmprego}/>
                    </div>

                    <h1 class="texto1">Estou procurando</h1>
                    <h1 class="texto1p2">emprego</h1>
                </a>
                

                <a class="juridica">

                    <h1 class="texto2">Estou procurando</h1>
                    <h1 class="texto2p2">profissionais</h1>

                    <div class="bloquinho2">
                        <img  class="imgEmpresa" src={imgEmpresa}/>
                    </div>

                </a>
                

            </section>   
            
        );
    };
};