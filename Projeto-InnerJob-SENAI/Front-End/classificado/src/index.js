import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Redirect, Switch } from 'react-router-dom';

import './index.css';

import Home from './pages/Home/Home';
import Redirecionamento from './pages/Redirecionamento/Redirecionamento';
import LoginCandidato from './pages/LoginCandidato/LoginCandidato';
import CadastroCandidato from './pages/CadastroCandidato/CadastroCandidato';




import reportWebVitals from './reportWebVitals';

const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={Home}/>
        <Route exact path="/r" component={Redirecionamento}/>
        <Route exact path="/lc"component={LoginCandidato}/>
        <Route exart path="/cc" component={CadastroCandidato}/>
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(
  routing,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
