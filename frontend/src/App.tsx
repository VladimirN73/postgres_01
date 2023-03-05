import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { getInfo } from './services/apiServiceFetch';

interface IState {
  info: string
}

class App extends Component<any, IState> {

  constructor(props: any) {
    super(props)
    this.state = {
      info: "loading...",
    }
  }

  public async componentDidMount(): Promise<void> {
    const info = await getInfo();

    this.setState({
      info: info ?? "loading..."
    })
  }
  //const apiService = new ApiServiceFetch();

  async info()
  {
    return 
  }

  public render() {
    return (
      <div className="App">
        <header className="App-header">
          <p>
            DB Info: {this.state.info}
          </p>
        </header>
      </div>
    );
  }
}
export default App;
