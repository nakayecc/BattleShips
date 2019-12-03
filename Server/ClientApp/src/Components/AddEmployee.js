import React, {Component} from "react";
import Board from "./Board";
import database from "./data/database"

import writeJsonFile from "write-json-file";

export default class AddEmployee extends Component {

    addEmployee(){
        let newRecord = database.users;
        database.users.push(
            {
                "id": "5",
                "name": "darius",
                "surname": "draven",
                "email": "darius@riot.com",
                "salary": "25000PLN"
            });
        JSON.stringify(database);
        (async () => {
            await writeJsonFile('./data/database.json', {database: true});
        })(database);



        console.log(newRecord);
    };
    render() {
        return (
            <tr>
                <th colSpan="6"><button type="submit" className="btn-primary" onClick={this.addEmployee}>Add Employer</button></th>
            </tr>
        );
    }

}