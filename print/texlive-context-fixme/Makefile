# $FreeBSD$

PORTNAME=	context-fixme
PORTVERSION=	20150412
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Make editorial marks on a document.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
