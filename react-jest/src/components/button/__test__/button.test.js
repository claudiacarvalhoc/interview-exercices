import React from 'react';
import ReactDOM from 'react-dom';
import { render, cleanup } from '@testing-library/react';

import Button from '../button.js';
import '@testing-library/jest-dom/extend-expect';



afterEach(cleanup);

it("renders without crashing", () => {
    const div = document.createElement('div');
    ReactDOM.render(<Button label='hello'></Button>, div);
    ReactDOM.unmountComponentAtNode(div);
});

it("renders button correctly", () => {
    const { getByTestId } = render(<Button label='hello'></Button>);
    expect(getByTestId('button')).toHaveTextContent('hello');
});



/**
 * C:\Users\joao.costa\source\repos\interview-exercices\react-jest\node_modules\@types\testing-library__dom\queries.d.ts
 * check this file to get other methods
 **/

it("renders button correctly __ 2", () => {
    const { getByTestId } = render(<Button label='hello'></Button>);
    expect(getByTestId('button')).toHaveTextContent('hello');
});


// TO BE IMPROVED...
// an error is thrown using the 'react-test-renderer'
/**
 * import renderer from 'react-test-renderer';
 * at Resolver.resolveModule (node_modules/jest-resolve/build/index.js:259:17)
      at Object.<anonymous> (src/components/button/__test__/button.test.js:8:1)
 */

// it("matches snapshot", () => {
//     const tree = renderer.create(<Button label="hello" />).toJson();
//     expect(tree).toMatchSnapshot();
// });