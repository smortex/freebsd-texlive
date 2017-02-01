# $FreeBSD$

PORTNAME=	newtx
PORTVERSION=	20170201
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Alternative uses of the TX fonts, with improved metrics

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/kastrup/binhex.tex:${PORTSDIR}/print/texlive-kastrup

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
