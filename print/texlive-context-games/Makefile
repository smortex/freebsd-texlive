# $FreeBSD$

PORTNAME=	context-games
PORTVERSION=	20150412
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The context-games package

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/afm/public/skaknew/AlphaDia.afm:${PORTSDIR}/print/texlive-skaknew \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
