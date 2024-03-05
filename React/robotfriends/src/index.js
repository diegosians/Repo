import React from 'react';
import ReactDOM from 'react-dom';
import Card from './Card';
import './index.css';
import "tachyons";
import {robots} from "./robots"

ReactDOM.render(
  <div>
    <Card id={robots[0].id} nome={robots[0].nome} email={robots[0].email}/>
    <Card id={robots[1].id} nome={robots[1].nome} email={robots[1].email}/>
    <Card id={robots[2].id} nome={robots[2].nome} email={robots[2].email}/>
  </div>

  ,document.getElementById('root')
);
