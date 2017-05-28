import React, { Component } from 'react';
import { Col, Nav, NavItem, Row, Tab } from 'react-bootstrap'
import './LispInterpreterWindow.css';

class LispInterpreterWindow extends Component {
    render() {
        return (
            <div className="App-interpreter-window section">
                <div className="App-interpreter-nav-wrapper">
                    <Tab.Container id="App-interpreter-nav" defaultActiveKey="first">
                        <Row className="clearfix">
                        <Col sm={2}>
                            <Nav bsStyle="tabs" stacked>
                            <NavItem className="App-interpreter-nav-item" eventKey="first">
                                Tab 1
                            </NavItem>
                            <NavItem className="App-interpreter-nav-item" eventKey="second">
                                Tab 2
                            </NavItem>
                            </Nav>
                        </Col>
                        <Col sm={10}>
                            <Tab.Content animation>
                            <Tab.Pane eventKey="first">
                                Tab 1 content
                            </Tab.Pane>
                            <Tab.Pane eventKey="second">
                                Tab 2 content
                            </Tab.Pane>
                            </Tab.Content>
                        </Col>
                        </Row>
                    </Tab.Container>
                </div>
            </div>
        );
    }
}

export default LispInterpreterWindow;