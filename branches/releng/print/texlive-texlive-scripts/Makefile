# $FreeBSD$

PORTNAME=	texlive-scripts
PORTVERSION=	20140120
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	TeX Live infrastructure programs

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
