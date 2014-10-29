# $FreeBSD$

PORTNAME=	context-vim
PORTVERSION=	20140815
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Generate Context syntax highlighting code from vim.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/context/third/filter/t-filter.mkii:${PORTSDIR}/print/texlive-context-filter \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
