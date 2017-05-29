import React from 'react';
import ReactDOM from 'react-dom';
import DebugWindow from './DebugWindow.js'

it('renders without crashing', () => {
  const div = document.createElement('div');
  ReactDOM.render(<DebugWindow />, div);
});
