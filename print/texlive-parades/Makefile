# $FreeBSD$

PORTNAME=	parades
PORTVERSION=	20160316
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Tabulators and space between paragraphs in galley approach

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
