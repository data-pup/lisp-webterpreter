import React, { Component } from 'react';
import { Col, Nav, NavItem, Row, Tab } from 'react-bootstrap'
import './LispInterpreterWindow.css';

class LispInterpreterWindow extends Component {
    render() {
        return (
        <Tab.Container id="left-tabs-example" defaultActiveKey="first">
            <Row className="clearfix">
            <Col sm={4}>
                <Nav bsStyle="tabs" stacked>
                <NavItem eventKey="first">
                    Tab 1
                </NavItem>
                <NavItem eventKey="second">
                    Tab 2
                </NavItem>
                </Nav>
            </Col>
            <Col sm={8}>
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
        );
    }
}

export default LispInterpreterWindow;