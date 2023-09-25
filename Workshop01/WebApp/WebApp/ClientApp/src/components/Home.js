import React, { Component, useCallback, useContext, useEffect, useState } from 'react';
import tick from '../image/tick.png';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { DynamicMessage: [], loading: true };
    }

    componentDidMount() {
        this.populateMessage();
    }

    async populateMessage() {
        const response = await fetch('DynamicMessage');
        const data = await response.json();
        this.setState({ DynamicMessage: data, loading: false });
    }

    render() {
        return (
            <div>
                <p>< img style={{ width: "5%" }} src={tick} /></p>
                <br></br>

                <p>{this.state.DynamicMessage.message}</p>
                <br></br>
                <p>Repository https://github.com/inertjl/CFDSA</p>

            </div>
        );
    }
}
