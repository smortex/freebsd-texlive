# New ports collection makefile for:	texlive-context-vim
# Date created:		13/03/2010 04:21:49
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-vim
PORTVERSION=	20120421
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Generate Context syntax highlighting code from vim.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/context/third/filter/t-filter.mkii:${PORTSDIR}/print/texlive-context-filter \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
