import React, { Component } from 'react';
import './AppHeader.css';
import logo from './logo.svg';

class AppHeader extends Component {
  render() {
    return (
        <div className="App-header">
            <h2 classname="App-title">Welcome to my LISP Interpreter!</h2>
            <div className="App-logo-wrapper">
            <img src={logo} className="App-logo" alt="logo" />
            </div>
            <div className="App-intro">
            <p>This is a project aiming to implemenent a simple client-side LISP interpreter using React.</p>
            </div>
        </div>
    );
  }
}

export default AppHeader;