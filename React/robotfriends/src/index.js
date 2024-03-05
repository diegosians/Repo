import React from 'react';
import ReactDOM from 'react-dom'
import CardList from './CardList.js'
import './index.css';
import {robots} from "./robots"
import "tachyons";


ReactDOM.render(
  <CardList robots = {robots}/>
  ,document.getElementById('root')
);
