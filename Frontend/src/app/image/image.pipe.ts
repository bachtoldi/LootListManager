import { Pipe, PipeTransform } from '@angular/core';
import * as images from './images';

@Pipe({
    name: 'image'
})

export class ImagePipe implements PipeTransform {
    constructor() { }

    transform(value: string, args: any[]): any {
        if (!value) { return; }
        return images.IMAGES[value];
    }
}
