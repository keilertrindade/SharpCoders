
export interface Content {
    type: 'paragraph' |'link' |'title' | 'image',
    message?: string,
    link?: string,
    displayedText?: string,
    imageLink?: string | null,
    alternativeText?: string | null,
    testNullable?: string;
    
}

