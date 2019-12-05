import React, {Component, Fragment} from "react";
import axios from "../../axios/axios";
import SquarePlayer from "./SquarePlayer";

export default class Board extends Component {
    state = {
        squares: [],
        isLoading: true
    };

    componentDidMount() {
        this.getSquares().then(response => {
            this.setState({squares: response});
            this.setState({isLoading: false});
        });

    }

    getSquares = () => {
        return axios.get('/enemy')
            .then(response => {
                console.log(response.data);
                return response.data;

            });
    };

    updateSquare = () => {
        this.setState({isLoading: true});
        setTimeout(function () {
            this.getSquares().then(response => {
                this.setState({squares: response});
                this.setState({isLoading: false});
            });
        }.bind(this), 350)
    };



    render() {
        let counter = 0;
        let content = this.state.squares.map(square =>
            <SquarePlayer
                square={square}
                squareId={counter++}
                key={counter++}
                isLoading={this.state.isLoading}
            />);
        return (
            this.state.isLoading === false ? content : <div className="spinner-border" role="status">
                <span className="sr-only">Loading...</span>
            </div>
        )
    }
}