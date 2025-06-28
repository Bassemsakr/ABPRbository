import type { EntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';

export interface ActiveAuthorLookupDto {
  id?: string;
  name?: string;
}

export interface AuthorDto extends EntityDto<string> {
  name?: string;
  birthDate?: string;
  shortBio?: string;
  isActive: boolean;
}

export interface CreateAuthorDto {
  name: string;
  birthDate: string;
  shortBio?: string;
  isActive: boolean;
}

export interface GetAuthorListDto extends PagedAndSortedResultRequestDto {
  filter?: string;
}

export interface UpdateAuthorDto {
  name: string;
  birthDate: string;
  shortBio?: string;
  isActive: boolean;
}
