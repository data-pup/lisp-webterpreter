import React from 'react';
import ReactDOM from 'react-dom';
import LispInterpreterWindow from './LispInterpreterWindow';

it('renders without crashing', () => {
  const div = document.createElement('div');
  ReactDOM.render(<LispInterpreterWindow />, div);
});
