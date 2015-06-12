# $FreeBSD$

PORTNAME=	context-ruby
PORTVERSION=	20150412
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Ruby annotations in ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
