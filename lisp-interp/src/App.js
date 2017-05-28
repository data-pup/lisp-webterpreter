import React, { Component } from 'react';
import AppHeader from './components/AppHeader/AppHeader';
import LispInterpreterWindow from './components/LispInterpreterWindow/LispInterpreterWindow';
import './App.css';

class App extends Component {
  render() {
    return (
      <div>
        <AppHeader />
        <LispInterpreterWindow />
      </div>
    );
  }
}

export default App;
