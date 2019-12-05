import React, {Component} from 'react';
import './css/custom.css'
import {Layout} from "./Components/Layout";
import {Route} from "react-router-dom";
import Home from "./Components/Home";




export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/game' component={Home} />

            </Layout>

        );
    }
}