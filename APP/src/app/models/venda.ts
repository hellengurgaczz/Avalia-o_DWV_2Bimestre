import { ItemVenda } from './item-venda';
import { FormasPag } from './formasPag';


export interface Venda{
    id?:number;
    cliente: string;
    formaId: number;
    formaPag?: FormasPag[];
    itemVendaId: number;
    itemVenda?: ItemVenda[];
}