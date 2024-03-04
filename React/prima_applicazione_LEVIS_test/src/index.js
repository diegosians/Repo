import React from 'react';
import ReactDOM from 'react-dom';
import Hello from './Hello';
import './index.css';
import "tachyons";

ReactDOM.render(
  <Hello informazione ={"E-commerce"+" alternativo"}/>,
  document.getElementById('root')
);
