import React, { Component } from 'react';
import { Col, Nav, NavItem, Row, Tab } from 'react-bootstrap'
import DebugWindow from './DebugWindow/DebugWindow.js'
import './LispInterpreterWindow.css';

class LispInterpreterWindow extends Component {

    constructor(props) {
        super(props);
        this.state = props;
    }

    render() {
        return (
            <div className="App-interpreter-wrapper section">
                <Tab.Container id="App-interpreter-window" defaultActiveKey="first">
                    <Row className="clearfix">
                    <Col sm={2} className="App-interpreter-nav">
                        <Nav bsStyle="tabs" stacked>
                        <NavItem className="App-interpreter-nav-item" eventKey="first">
                            Tab 1
                        </NavItem>
                        <NavItem className="App-interpreter-nav-item" eventKey="second">
                            Tab 2
                        </NavItem>
                        </Nav>
                    </Col>
                    <Col sm={8} className="App-Interpreter-content">
                        <Tab.Content animation>
                        <Tab.Pane eventKey="first">
                            Tab 1 content
                        </Tab.Pane>
                        <Tab.Pane eventKey="second">
                            <DebugWindow history={['hello', 'world']}/>
                        </Tab.Pane>
                        </Tab.Content>
                    </Col>
                    </Row>
                </Tab.Container>
            </div>
        );
    }
}

export default LispInterpreterWindow;